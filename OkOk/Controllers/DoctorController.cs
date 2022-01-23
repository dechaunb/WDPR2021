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

namespace OkOk.Controllers;

[Authorize(Roles = "Doctor")]
public class DoctorController : Controller
{
    private readonly ILogger<DoctorController> _logger;
    private readonly ApplicationDbContext _context;
    private readonly UserManager<DoctorApplicationUser> _userManager;
    private readonly SignInManager<DoctorApplicationUser> _signInManager;

    public DoctorController(
        ILogger<DoctorController> logger, 
        ApplicationDbContext context,
        SignInManager<DoctorApplicationUser> signInManager,
        UserManager<DoctorApplicationUser> userManager
        )
    {
        _logger = logger;
        _context = context;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        DoctorApplicationUser user = await _userManager.GetUserAsync(User);

        DoctorDashboardViewModel doctorDashboard = new DoctorDashboardViewModel();
        doctorDashboard.SignUpRequestsDashboard = await _context.SignUpRequests
                                                            .Include(sur => sur.DoctorApplicationUser)
                                                            .Include(sur => sur.ClientApplicationUser)
                                                            .Where(sur => sur.DoctorApplicationUser.Equals(user))
                                                            .Where(sur => sur.Handled.Equals(false))
                                                            .ToListAsync();

        doctorDashboard.ClientsDashboard = await _context.SignUpRequests
                                                            .Include(sur => sur.DoctorApplicationUser)
                                                            .Include(sur => sur.ClientApplicationUser)
                                                            .Where(sur => sur.DoctorApplicationUser.Equals(user))
                                                            .Where(sur => sur.Handled.Equals(true))
                                                            .Select(sur => sur.ClientApplicationUser)
                                                            .ToListAsync();

        doctorDashboard.AppointmentsDashboard = await _context.Treatments
                                                            .Include(treat => treat.DoctorApplicationUser)
                                                            .Include(treat => treat.ClientApplicationUser)
                                                            .Where(treat => treat.DoctorApplicationUser.Equals(user))
                                                            //Kijk of datum in de toekomst is of gelijk aan vandaag
                                                            .Where(treat => treat.DateTime.CompareTo(DateTime.Now) > 0 || treat.DateTime.Date.Equals(DateTime.Today))
                                                            .ToListAsync();

        doctorDashboard.AppointmentsTodayDashboard = await _context.Treatments
                                                            .Include(treat => treat.DoctorApplicationUser)
                                                            .Include(treat => treat.ClientApplicationUser)
                                                            .Where(treat => treat.DoctorApplicationUser.Equals(user))
                                                            //Kijk of datum in de toekomst is
                                                            .Where(treat => treat.DateTime.Date.Equals(DateTime.Today))
                                                            .OrderBy(treat => treat.DateTime)
                                                            .ToListAsync();

        doctorDashboard.RecentClientsDashboard = await _context.ClientApplicationUsers
                                                            .Include(client => client.Treatments)
                                                                .ThenInclude(treat => treat.DoctorApplicationUser)
                                                            .Where(client => client.Treatments
                                                                .Any(treat => treat.DoctorApplicationUser.Equals(user)))
                                                            .ToListAsync();

        List<Message> first = _context.ChatApplicationUsers
                                    .Include(cau => cau.Sent)
                                    .Include(cau => cau.Received)
                                    .FirstOrDefault(cau => cau.Id.Equals(user.Id))
                                    .Sent.ToList();
        List<Message> second = _context.ChatApplicationUsers
                                    .Include(cau => cau.Sent)
                                    .Include(cau => cau.Received)
                                    .FirstOrDefault(cau => cau.Id.Equals(user.Id))
                                    .Received.ToList();
        second.ForEach(item => first.Add(item));

        doctorDashboard.MessagesDashboard = first;
                                                            

        
        return View(doctorDashboard);
    }

    public async Task<IActionResult> SignUpRequest(string id)
    {
        DoctorApplicationUser user = await _userManager.GetUserAsync(User);

        var signUpRequest = _context.SignUpRequests   
                                            .Include(sur => sur.ClientApplicationUser)
                                            .Include(sur => sur.DoctorApplicationUser)
                                            .Where(sur => sur.DoctorApplicationUser.Equals(user))
                                            .Where(sur => !sur.Handled)
                                            .Single(sur => sur.Id.ToString().ToLower().Equals(id));

        return View(signUpRequest);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> grantAccess(string id)
    {
        var user = await _userManager.GetUserAsync(User);
        var signUpRequest = await _context.SignUpRequests
                                            .Include(sur => sur.ClientApplicationUser)
                                            .Include(sur => sur.DoctorApplicationUser)
                                            .Where(sur => sur.DoctorApplicationUser.Equals(user))
                                            .Where(sur => !sur.Handled)
                                            .FirstOrDefaultAsync(sur => sur.Id.ToString().ToLower().Equals(id));

        var clientApplicationUser = await _context.ClientApplicationUsers
                                            .FirstOrDefaultAsync(client => client.Equals(signUpRequest.ClientApplicationUser));

        signUpRequest.Handled = true;
        clientApplicationUser.LockedOutReason = null;
        clientApplicationUser.LockoutEnd = null;
        clientApplicationUser.LockoutEnabled = false;

        _context.ClientApplicationUsers.Attach(clientApplicationUser);
        _context.SignUpRequests.Attach(signUpRequest);
        await _context.SaveChangesAsync();
        
        return RedirectToPage("Account/MakeGuardian");
    }

    public async Task<ActionResult> denyAccess(string id)
    {
        var user = await _userManager.GetUserAsync(User);
        var signUpRequest = await _context.SignUpRequests
                                            .Include(sur => sur.ClientApplicationUser)
                                            .Include(sur => sur.DoctorApplicationUser)
                                            .Where(sur => sur.DoctorApplicationUser.Equals(user))
                                            .Where(sur => !sur.Handled)
                                            .FirstOrDefaultAsync(sur => sur.Id.ToString().ToLower().Equals(id));

        var clientApplicationUser = await _context.ClientApplicationUsers
                                            .FirstOrDefaultAsync(client => client.Equals(signUpRequest.ClientApplicationUser));

        signUpRequest.Handled = true;

        _context.SignUpRequests.Attach(signUpRequest);
        _context.ClientApplicationUsers.Remove(clientApplicationUser);
        await _context.SaveChangesAsync();

        DoctorDashboardViewModel doctorDashboard = new DoctorDashboardViewModel();
        doctorDashboard.SignUpRequestsDashboard = await _context.SignUpRequests
                                                            .Include(sur => sur.DoctorApplicationUser)
                                                            .Include(sur => sur.ClientApplicationUser)
                                                            .Where(sur => sur.DoctorApplicationUser.Equals(user))
                                                            .Where(sur => sur.Handled.Equals(false))
                                                            .ToListAsync();

        doctorDashboard.ClientsDashboard = await _context.SignUpRequests
                                                            .Include(sur => sur.DoctorApplicationUser)
                                                            .Include(sur => sur.ClientApplicationUser)
                                                            .Where(sur => sur.DoctorApplicationUser.Equals(user))
                                                            .Where(sur => sur.Handled.Equals(true))
                                                            .Select(sur => sur.ClientApplicationUser)
                                                            .ToListAsync();

        doctorDashboard.AppointmentsDashboard = await _context.Treatments
                                                            .Include(treat => treat.DoctorApplicationUser)
                                                            .Include(treat => treat.ClientApplicationUser)
                                                            .Where(treat => treat.DoctorApplicationUser.Equals(user))
                                                            //Kijk of datum in de toekomst is of gelijk aan vandaag
                                                            .Where(treat => treat.DateTime.CompareTo(DateTime.Now) > 0 || treat.DateTime.Date.Equals(DateTime.Today))
                                                            .ToListAsync();

        doctorDashboard.AppointmentsTodayDashboard = await _context.Treatments
                                                            .Include(treat => treat.DoctorApplicationUser)
                                                            .Include(treat => treat.ClientApplicationUser)
                                                            .Where(treat => treat.DoctorApplicationUser.Equals(user))
                                                            //Kijk of datum in de toekomst is
                                                            .Where(treat => treat.DateTime.Date.Equals(DateTime.Today))
                                                            .OrderBy(treat => treat.DateTime)
                                                            .ToListAsync();

        doctorDashboard.RecentClientsDashboard = await _context.ClientApplicationUsers
                                                            .Include(client => client.Treatments)
                                                                .ThenInclude(treat => treat.DoctorApplicationUser)
                                                            .Where(client => client.Treatments
                                                                .Any(treat => treat.DoctorApplicationUser.Equals(user)))
                                                            .ToListAsync();

        List<Message> first = _context.ChatApplicationUsers
                                    .Include(cau => cau.Sent)
                                    .Include(cau => cau.Received)
                                    .FirstOrDefault(cau => cau.Id.Equals(user.Id))
                                    .Sent.ToList();
        List<Message> second = _context.ChatApplicationUsers
                                    .Include(cau => cau.Sent)
                                    .Include(cau => cau.Received)
                                    .FirstOrDefault(cau => cau.Id.Equals(user.Id))
                                    .Received.ToList();
        second.ForEach(item => first.Add(item));

        doctorDashboard.MessagesDashboard = first;

        return View("Index", doctorDashboard);
    }

    public async Task<IActionResult> Appointments()
    {
        var user = await _userManager.GetUserAsync(User);

        var appointments = await _context.Treatments
                                .Include(treat => treat.DoctorApplicationUser)
                                .Include(treat => treat.ClientApplicationUser)
                                .Where(treat => treat.DoctorApplicationUser.Equals(user))
                                .ToListAsync();

        return View(appointments);
    }

    
    public async Task<IActionResult> CreateAppointment()
    {
        var user = await _userManager.GetUserAsync(User);

        var list = _context.SignUpRequests.Include(sur => sur.ClientApplicationUser).Include(sur => sur.DoctorApplicationUser).Where(sur => sur.DoctorApplicationUser.Equals(user)).Where(sur => sur.Handled).Where(sur => sur.ClientApplicationUser != null).Select(sur => sur.ClientApplicationUser).AsEnumerable();
        ViewData["ClientId"] = new SelectList(list, "Id", "UserName");
        return View();
    }

        
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateAppointment([Bind("Id,DateTime,Description,DoctorId,ClientId")] Treatment treatment)
    {
        DoctorApplicationUser user = await _userManager.GetUserAsync(User);
        if (ModelState.IsValid)
        {
            treatment.DoctorId = user.Id;
            treatment.Id = Guid.NewGuid();
            _context.Add(treatment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // var list = _context.ClientApplicationUsers;
        var list = _context.SignUpRequests.Include(sur => sur.ClientApplicationUser).Include(sur => sur.DoctorApplicationUser).Where(sur => sur.DoctorApplicationUser.Equals(user)).Where(sur => sur.Handled).Where(sur => sur.ClientApplicationUser != null).Select(sur => sur.ClientApplicationUser).AsEnumerable();
        ViewData["ClientId"] = new SelectList(list, "Id", "UserName", treatment.ClientId);
        return View(treatment);
    }

    private bool SignUpRequestExists(Guid id)
    {
        return _context.SignUpRequests.Any(e => e.Id == id);
    }
}
