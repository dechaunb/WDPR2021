using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OkOk.Data;
using OkOk.Models.Identity;
using OkOk.Models;

namespace OkOk.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<AdminController> _logger;

        public AdminController(UserManager<ApplicationUser> userManager, ILogger<AdminController> logger, ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // GET: Message
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DoctorApplicationUsers.Include(d => d.Treatments).Include(d => d.SignUpRequests);
            //MessagesTestData();
            //ReportTestData();
            ViewBag.UnfinishedReports = _context.Reports.Where(r => r.Handled == false).
            GroupBy(r => r.MessageReport.MessageId).
            Select(g => new{MessageId = g.Key, SenderId= _context.Messages.Where(r => r.Id == g.Key).Select(r => r.SenderId).Single()
            ,Aantal = g.Count(), Content= _context.Messages.Where(r => r.Id == g.Key).Select(r => r.Content).Single()}).OrderByDescending(r => r.Aantal).ToList();
            return View(await applicationDbContext.ToListAsync());
        }

        //Dit was om uit te testen of het overzicht van reports werkt. Kan weggehaald worden
        public void MessagesTestData(){
            SupportGroup sg = new SupportGroup(){
                Name= "Groep B",
                Description = "Tweede groep"
            };
            ClientApplicationUser client1 = new ClientApplicationUser(){
                FirstName = "Leon",
                LastName = "A",
                Address = new Address(){
                    HouseNumber = 1,
                    Street = "Straat",
                    City = "Delft",
                    ZipCode = "2121DW",
                    Country = "Nederland"
                },
            };
            ClientApplicationUser client2 = new ClientApplicationUser(){
                FirstName = "Gerard",
                LastName = "A",
                Address = new Address(){
                    HouseNumber = 1,
                    Street = "Straat",
                    City = "Delft",
                    ZipCode = "2121DW",
                    Country = "Nederland"
                },
                Received = new List<Message>(){
                    new Message(){
                        Content = "Lul",
                        DateTime = DateTime.Now,
                        Sender = client1,
                        SupportGroup = sg
                    },
                    new Message(){
                        Content = "Klootzak",
                        DateTime = DateTime.Now,
                        Sender = client1,
                        SupportGroup = sg
                    }
                }
            };

            _context.SupportGroups.Add(sg);
            _context.ChatApplicationUsers.Add(client1);
            _context.ChatApplicationUsers.Add(client2);

            _context.SaveChanges();

        }

        //Dit was om uit te testen of het overzicht van reports werkt. Kan weg gehaald worden
        public void ReportTestData(){
            Message m1 = _context.Messages.Where(m => m.Content == "Lul").First();
            Message m2 = _context.Messages.Where(m => m.Content == "Klootzak").First();

            Report report1 = new Report(){
                MessageReport = new MessageReport(){
                    MessageId = m1.Id,
                    Message = m1,
                }
            };
            Report report2 = new Report(){
                MessageReport = new MessageReport(){
                    MessageId = m2.Id,
                    Message = m2
                }
            };

            Report report3 = new Report(){
                MessageReport = new MessageReport(){
                    MessageId = m1.Id,
                    Message = m1
                }
            };
            _context.Reports.Add(report1);
            _context.Reports.Add(report2);
            _context.Reports.Add(report3);
            _context.SaveChanges();
        }

        public async Task<IActionResult> Roles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        public async Task<IActionResult> UserRoles()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRolesViewModel = new List<UserRolesViewModel>();
            foreach (ApplicationUser user in users)
            {
                var thisViewModel = new UserRolesViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.FirstName = user.FirstName;
                thisViewModel.LastName = user.LastName;
                thisViewModel.Roles = await GetUserRoles(user);
                userRolesViewModel.Add(thisViewModel);
            }

            return View(userRolesViewModel);
        }

        private async Task<List<string>> GetUserRoles(ApplicationUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(string roleName)
        {
            if (roleName != null)
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));
            }
            return RedirectToAction("Roles");
        }

        public async Task<IActionResult> ManageUserRoles(string userId)
    {
        ViewBag.userId = userId;
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
            return View("NotFound");
        }
        ViewBag.UserName = user.UserName;
        var model = new List<ManageUserRolesViewModel>();
        foreach (var role in _roleManager.Roles)
        {
            var userRolesViewModel = new ManageUserRolesViewModel
            {
                RoleId = role.Id,
                RoleName = role.Name
            };
            if (await _userManager.IsInRoleAsync(user, role.Name))
            {
                userRolesViewModel.Selected = true;
            }
            else
            {
                userRolesViewModel.Selected = false;
            }
            model.Add(userRolesViewModel);
        }
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> ManageUserRoles(List<ManageUserRolesViewModel> model, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return View();
        }
        var roles = await _userManager.GetRolesAsync(user);
        var result = await _userManager.RemoveFromRolesAsync(user, roles);
        if (!result.Succeeded)
        {
            ModelState.AddModelError("", "Cannot remove user existing roles");
            return View(model);
        }
        result = await _userManager.AddToRolesAsync(user, model.Where(x => x.Selected).Select(y => y.RoleName));
        if (!result.Succeeded)
        {
            ModelState.AddModelError("", "Cannot add selected roles to user");
            return View(model);
        }
        return RedirectToAction("UserRoles");
    }

    public async Task<IActionResult> BlockClient(string userId, Guid messageId){
        var user = await _userManager.FindByIdAsync(userId);
        ViewData["messageId"] = messageId;
        return View(user);
    }

    [HttpPost]
    public IActionResult BlockClient(string userId, string lockoutReason, Guid messageId){
        BlockUser(userId, lockoutReason, messageId);
        return RedirectToAction("Index");
    }

    
    public async void BlockUser(string userId, string lockedoutReason, Guid messageId){
        var user = await _userManager.FindByIdAsync(userId);
        if(user != null){ 
            if(user.LockoutEnabled == true)
            {
                ViewData["BlockMeldingInhoud"] =  "Cliënt is al geblokkeerd!";
                Console.WriteLine("Cliënt is al geblokkeerd!");
            }
            else
            {
                user.LockoutEnabled = true;
                user.LockoutEnd = DateTime.Now.AddDays(1);
                user.LockedOutReason = lockedoutReason;
                //Alle reports op true zetten waar de messageId mee overeen komt.
                var reports = _context.Reports.Where(r => r.MessageReport.MessageId == messageId);
                foreach (var item in reports)
                {
                    item.Handled = true;
                }
                ViewData["BlockMeldingInhoud"] =  "Cliënt geblokkeerd";
                Console.WriteLine("Cliënt geblokkeerd");
            }
        }
        else 
        {
            ViewData["BlockMeldingInhoud"] =  "Cliënt niet gevonden";
            Console.WriteLine("Cliënt niet gevonden");
        }
         _context.SaveChanges();
        
    }
    
    }
}
