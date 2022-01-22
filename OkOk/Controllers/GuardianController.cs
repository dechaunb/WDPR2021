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
    public class GuardianController : Controller{
        private readonly ApplicationDbContext _context;
        private readonly UserManager<GuardianApplicationUser> _userManager;

        public GuardianController(ApplicationDbContext context, UserManager<GuardianApplicationUser> userManager){
            _context = context;
            _userManager = userManager;
        }

        public async Task<ActionResult> Index(){
            var user = await _userManager.GetUserAsync(User);
            var guardians = _context.GuardianApplicationUsers
                                .Include(guardian => guardian.Children)
                                .FirstOrDefault(guardian => guardian.Equals(user));

            return View(guardians);
        }

        public IActionResult ChildChatFrequency(string id){
            var client = _context.ClientApplicationUsers
                            .Include(client => client.Sent)
                                .ThenInclude(m => m.SupportGroup)
                            .FirstOrDefault(client => client.Id.Equals(id) && !client.OldEnough);
            
            return View(client);
        }

        public IActionResult Child(string id)
        {
            var client = _context.ClientApplicationUsers
                            .Include(client => client.Sent)
                                .ThenInclude(m => m.SupportGroup)
                            .FirstOrDefault(client => client.Id.Equals(id));

            return View(client);
        }
    }
}