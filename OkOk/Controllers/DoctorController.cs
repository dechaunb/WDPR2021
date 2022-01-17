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
        
        return View(doctorDashboard);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> HandleRequest(string save, string cancel, Guid passedSignUpRequest, Guid passedClientApplicationUser)
    {
        var loggedUser = await _userManager.GetUserAsync(User);

        if(!string.IsNullOrEmpty(save))
        {
            _logger.LogInformation("ClientApplicationUser Accepted");
            ViewBag.Message = "Customer saved successfully!";
        }
        if (!string.IsNullOrEmpty(cancel))
        {
            _logger.LogInformation("ClientApplicationUser Denied");
            ViewBag.Message = "Gebruiker uitgesloten";
        }

        // signUpRequest.Handled = true;
        // clientApplicationUser.LockoutEnd = null;
        // clientApplicationUser.LockoutEnabled = false;
        // _context.SignUpRequests.Update(signUpRequest);
        // _context.ClientApplicationUsers.Update(clientApplicationUser);
        // _context.SaveChanges();


        return RedirectToAction("Index");
    }

    public async Task<ActionResult> OldHandle(string save, string cancel, Guid passedSignUpRequest, Guid passedClientApplicationUser)
    {
        var loggedUser = await _userManager.GetUserAsync(User);

        if(!string.IsNullOrEmpty(save))
        {
            _logger.LogInformation("ClientApplicationUser Accepted");
            ViewBag.Message = "Customer saved successfully!";
        }
        if (!string.IsNullOrEmpty(cancel))
        {
            _logger.LogInformation("ClientApplicationUser Denied");
            ViewBag.Message = "Gebruiker uitgesloten";
        }

        // signUpRequest.Handled = true;
        // clientApplicationUser.LockoutEnd = null;
        // clientApplicationUser.LockoutEnabled = false;
        // _context.SignUpRequests.Update(signUpRequest);
        // _context.ClientApplicationUsers.Update(clientApplicationUser);
        // _context.SaveChanges();


        return RedirectToAction("Index");
    }

    public async Task<IActionResult> HandleRequest(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signUpRequest = await _context.SignUpRequests.FindAsync(id);
            if (signUpRequest == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.ClientApplicationUsers, "Id", "Id", signUpRequest.ClientId);
            ViewData["DoctorId"] = new SelectList(_context.DoctorApplicationUsers, "Id", "Id", signUpRequest.DoctorId);
            return View(signUpRequest);
        }

        // POST: SignUpRequest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HandleRequest(Guid id, [Bind("Id,Handled,ClientId,DoctorId")] SignUpRequest signUpRequest)
        {
            if (id != signUpRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(signUpRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SignUpRequestExists(signUpRequest.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.ClientApplicationUsers, "Id", "Id", signUpRequest.ClientId);
            ViewData["DoctorId"] = new SelectList(_context.DoctorApplicationUsers, "Id", "Id", signUpRequest.DoctorId);
            return View(signUpRequest);
        }

        private bool SignUpRequestExists(Guid id)
        {
            return _context.SignUpRequests.Any(e => e.Id == id);
        }
}
