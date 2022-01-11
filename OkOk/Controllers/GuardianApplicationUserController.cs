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
            //Hard coded data. Kan weggehaald worden en vervangen worden door de Guardian die op dat moment is ingelogd
            GuardianApplicationUser g = new GuardianApplicationUser(){
                FirstName = "Gerard",
                LastName = "A",
                Children = new List<ClientApplicationUser>(){
                    new ClientApplicationUser(){
                        FirstName = "Leon",
                        LastName = "A",
                        Address = new Address(){
                            HouseNumber = 1,
                            Street = "Straat",
                            City = "Delft",
                            ZipCode = "2121DW",
                            Country = "Nederland"
                        },
                        Messages = new List<Message>(){
                            new Message(){
                                Content = "Hoi",
                                DateTime = DateTime.Now,
                                SupportGroup = new SupportGroup(){
                                    Name = "Groep A",
                                    Description = "Eerste groep"
                                }
                            },
                            new Message(){
                                Content = "Hallo",
                                DateTime = DateTime.Now,
                                SupportGroup = new SupportGroup(){
                                    Name= "Groep B",
                                    Description = "Tweede groep"
                                }
                            }
                        }
                    },
                    new ClientApplicationUser(){
                        FirstName = "Appel",
                        LastName = "A",
                        Address = new Address(){
                            HouseNumber = 1,
                            Street = "Straat",
                            City = "Delft",
                            ZipCode = "2121DW",
                            Country = "Nederland"
                        },
                        Messages = new List<Message>(){
                            new Message(){
                                Content = "Hoi",
                                DateTime = DateTime.Now,
                                SupportGroup = new SupportGroup(){
                                    Name = "Groep A",
                                    Description = "Eerste groep"
                                }
                            },
                            new Message(){
                                Content = "Hallo",
                                DateTime = DateTime.Now,
                                SupportGroup = new SupportGroup(){
                                    Name= "Groep B",
                                    Description = "Tweede groep"
                                }
                            }
                        }
                    }
                }
            };
            _context.SaveChanges();
            //Dit moet uiteindelijk veranderd worden naar de ingelogde guardian die is ingelogd!
            return View(_context.GuardianApplicationUsers.Include(g => g.Children).Where(g => g.FirstName == "Gerard").First());
        }

        public IActionResult ChildChatFrequency(string id){
            ClientApplicationUser c = _context.ClientApplicationUsers.Include(g => g.Messages).ThenInclude(m => m.SupportGroup).Single(g => g.Id == id);
            if (c.Messages == null){
                ViewData["SortedMessages"] = null;
            }
            else{
                ViewData["SortedMessages"] = c.Messages.OrderByDescending(m => m.DateTime).ToList();
            }
            
            return View(c);
        }
    }
}