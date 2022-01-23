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

[Authorize(Roles = "Client")]
public class ClientController : Controller
{
    private readonly ILogger<ClientController> _logger;
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ClientApplicationUser> _userManager;
    private readonly SignInManager<ClientApplicationUser> _signInManager;

    public ClientController(
        ILogger<ClientController> logger, 
        ApplicationDbContext context,
        SignInManager<ClientApplicationUser> signInManager,
        UserManager<ClientApplicationUser> userManager
        )
    {
        _logger = logger;
        _context = context;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        ClientApplicationUser user = await _userManager.GetUserAsync(User);

        ClientDashboardViewModel clientDashboard = new ClientDashboardViewModel();

        clientDashboard.AppointmentsDashboard = await _context.Treatments
                                                            .Include(treat => treat.ClientApplicationUser)
                                                            .Include(treat => treat.ClientApplicationUser)
                                                            .Where(treat => treat.ClientApplicationUser.Equals(user))
                                                            //Kijk of datum in de toekomst is of gelijk aan vandaag
                                                            .Where(treat => treat.DateTime.CompareTo(DateTime.Now) > 0 || treat.DateTime.Date.Equals(DateTime.Today))
                                                            .ToListAsync();

        clientDashboard.AppointmentsTodayDashboard = await _context.Treatments
                                                            .Include(treat => treat.ClientApplicationUser)
                                                            .Include(treat => treat.ClientApplicationUser)
                                                            .Where(treat => treat.ClientApplicationUser.Equals(user))
                                                            //Kijk of datum in de toekomst is
                                                            .Where(treat => treat.DateTime.Date.Equals(DateTime.Today))
                                                            .OrderBy(treat => treat.DateTime)
                                                            .ToListAsync();

        clientDashboard.RecentDoctorsDashboard = await _context.DoctorApplicationUsers
                                                            .Include(doctor => doctor.Treatments)
                                                                .ThenInclude(treat => treat.ClientApplicationUser)
                                                            .Where(doctor => doctor.Treatments
                                                                .Any(treat => treat.ClientApplicationUser.Equals(user)))
                                                            .ToListAsync();
        clientDashboard.AantalBerichten = await _context.Messages.Where(it=>it.Receivers.Contains(user)).CountAsync();
        
        return View(clientDashboard);
    }
    public IActionResult Messages(){
        return View();
    }
    public IActionResult Appointments(){
        return View();
    }
    public async Task<JsonResult> GetAppointments(){
        ClientApplicationUser user = await _context.ClientApplicationUsers.Include(it=>it.Treatments).SingleAsync(it=>it.Id== _userManager.GetUserId(User));
        var list = _context.Treatments.Where(it=>it.ClientId==user.Id).Select(it=>new{
            Title=it.Description+" Dr. "+it.DoctorApplicationUser.LastName,
            DateTime=it.DateTime.ToString()
        });
        return Json(list);
    }

}
