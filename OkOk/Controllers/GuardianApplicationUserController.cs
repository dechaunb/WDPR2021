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
    public class GuardianApplicationUserController : Controller{
        private readonly ApplicationDbContext _context;

        public GuardianApplicationUserController(ApplicationDbContext context){
            _context = context;
        }

        [Route("/Guardian/Index")]
        public IActionResult Index(){
            GuardianApplicationUser g = new GuardianApplicationUser(){
                FirstName = "Gerrit",
                LastName = "A",
                Children = new List<ClientApplicationUser>(){
                    new ClientApplicationUser(){
                        FirstName = "Arie",
                        LastName = "A",
                        Address = new Address(){
                            HouseNumber = 1,
                            Street = "Straat",
                            City = "Delft",
                            ZipCode = "2121DW",
                            Country = "Nederland"
                        }
                    },
                    new ClientApplicationUser(){
                        FirstName = "Juliët",
                        LastName = "A",
                        Address = new Address(){
                            HouseNumber = 1,
                            Street = "Straat",
                            City = "Delft",
                            ZipCode = "2121DW",
                            Country = "Nederland"
                        }
                    }
                }
            };
            //_context.GuardianApplicationUsers.Add(g);
            _context.SaveChanges();

            //ViewData["Children"] = _context.GuardianApplicationUsers;
            return View(_context.GuardianApplicationUsers.Include(g => g.Children).First());
        }

        //[Route("/GuardianApplicationUser/ChildChatFrequency/{id}")]
        public IActionResult ChildChatFrequency(ClientApplicationUser child){
            if (child.Messages == null){
                ViewData["SortedMessages"] = null;
            }
            else{
                ViewData["SortedMessages"] = child.Messages.OrderByDescending(m => m.DateTime).ToList();
            }
            return View(child);
        }
    }
}