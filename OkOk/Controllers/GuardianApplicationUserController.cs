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
    [Authorize(Roles = "Guardian")]
    public class GuardianApplicationUserController : Controller{
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public GuardianApplicationUserController(UserManager<ApplicationUser> userManager, ApplicationDbContext context){
            _context = context;
            _userManager = userManager;
        }

        [Route("/Guardian/Index")]
        public IActionResult Index(){
            var userId = _userManager.GetUserId(User);
            var loggedInUser = _context.GuardianApplicationUsers.Include(g => g.Children).Single(g => g.Id == userId);
            return View(loggedInUser);
            //_context.GuardianApplicationUsers.Include(g => g.Children).Where(g => g.FirstName == "Gerard").First()
        }

        public IActionResult ChildChatFrequency(string id){
            var userId = _userManager.GetUserId(User);
            var loggedInUser = _context.GuardianApplicationUsers.Include(g => g.Children).ThenInclude(g => g.Received).ThenInclude(m => m.SupportGroup).Single(g => g.Id == userId);
            ClientApplicationUser c = loggedInUser.Children.Single(g => g.Id == id);
            if (c.Received == null){
                ViewData["SortedMessages"] = null;
            }
            else{
                ViewData["SortedMessages"] = c.Received.OrderByDescending(m => m.DateTime).ToList();
            }
            
            return View(c);
        }
    }
}