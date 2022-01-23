using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OkOk.Data;
using OkOk.Models;
using OkOk.Models.Identity;
using Microsoft.AspNetCore.Identity;
using OkOk.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace OkOk.Controllers
{
    [Authorize(Roles="Doctor,Client")]
    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ChatApplicationUser> _UserManager;
        
        public MessageController(ApplicationDbContext context, UserManager<ChatApplicationUser> userManager)
        {
            _context = context;
            _UserManager = userManager;
        }

        public IActionResult Chats(){
            
            return RedirectToAction("Messages",User.IsInRole("Doctor")?"Doctor":"Client");
        }

        public IActionResult Index()
        {
            return View();
        }

        //Report button action
        public async Task Report(string id){
            if (await _context.Messages.AnyAsync(it=>it.Id.ToString().ToLower()==id)){
                Message message = await _context.Messages.SingleAsync(it=>it.Id.ToString().ToLower()==id);
                _context.MessageReports.Add(new MessageReport(){MessageId=message.Id, Report=new Report()});
                _context.Update(message);
                await _context.SaveChangesAsync();
            }
        }

        //Groups Chats

        public async Task<IActionResult> GroupHub(string id){
            if (_context.SupportGroups.Any(e => e.Id.ToString().ToLower() == id)){
                var user = await _UserManager.GetUserAsync(User);
                ViewBag.User= user;
                SupportGroup group = (await _context.SupportGroups.Include(it=>it.ChatApplicationUsers).Include(it=>it.Received).ThenInclude(it=>it.Sender).SingleAsync(it=>it.Id.ToString().ToLower()==id));
                ViewBag.GroupName= group.Name;
                ViewBag.GroupId = id;
                ViewBag.Messages = group.Received.OrderBy(it=>it.DateTime).ToList();
                ViewBag.Users = JsonConvert.SerializeObject((await _context.SupportGroups.Include(it=>it.ChatApplicationUsers).SingleAsync(it=>it.Id.ToString().ToLower()==id)).ChatApplicationUsers.Select(it=>new{
                    UserName=it.UserName,
                    FirstName=it.FirstName
                }).ToArray());
                return View();

            }else return NotFound();
        }

        public async Task<JsonResult> GetGroupChats(){
            var user = await _context.ChatApplicationUsers.Include(it=>it.SupportGroups).ThenInclude(it=>it.Received).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));

            var groupchats = user.SupportGroups.Select(
                it=>{
                    if (_context.Messages.Where(message=>message.SupportGroup==it).Count()>0)
                        return new ValueTuple<SupportGroup,Message>(
                            it, 
                            it.Received.OrderBy(it=>it.DateTime).Last());
                    else
                        return new ValueTuple<SupportGroup,Message>(
                            it, 
                            new Message(){Content="Geen bericht gevonden",DateTime=DateTime.MinValue});
            }).OrderByDescending(it=>it.Item2.DateTime);

            return Json(groupchats.Select(it=>new{
                id=it.Item1.Id,
                name=it.Item1.Name,
                lastmessage=it.Item2.Content,
                DateTime=it.Item2.DateTime
            }));
        }

        public async Task<IActionResult> NewGroupChat(int? pageNumber, string searchString, string currentFilter){
            ViewData["CurrentFilter"] = searchString;
            var user = await _context.ChatApplicationUsers.Include(it=>it.SupportGroups).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));            

            ViewBag.CanCreate = User.IsInRole("Doctor");

            if (searchString != null){
                pageNumber = 1;
            }else{
                searchString = currentFilter;
            }

            if(_context.SupportGroups.Count()<3){
                _context.Add(
                    new SupportGroup(){
                        Id=Guid.NewGuid(),
                        Name="Groep 1",
                        Description="ADHD"
                    }
                );
                _context.Add(
                    new SupportGroup(){
                        Id=Guid.NewGuid(),
                        Name="Groep 2",
                        Description="Autisme"
                    }
                );
                _context.Add(
                    new SupportGroup(){
                        Id=Guid.NewGuid(),
                        Name="Groep 3",
                        Description="AngstStoornissen"
                    }
                );
                await _context.SaveChangesAsync();
            }

            var lijst = _context.SupportGroups.Where(it=>!it.ChatApplicationUsers.Contains(user)).ToList();
            
            if (!String.IsNullOrEmpty(searchString))
            {
                lijst= lijst.Where(s => s.Name.Contains(searchString)
                                    || s.Description.Contains(searchString)).ToList();
            }

            ViewBag.clientenLijst=_context.ClientApplicationUsers;


            var pageSize= 10;
            return View(new PaginatedList<SupportGroup>(lijst,lijst.Count(),pageNumber??1,pageSize));
        }

        [HttpPost]
        public async Task<IActionResult> NewGroupChat(string id){
            var Group = _context.SupportGroups.Single(it=>it.Id.ToString().ToLower()==id);
            var user = await _context.ChatApplicationUsers.Include(it=>it.SupportGroups).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));
            user.SupportGroups.Add(Group);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GroupHub),"Message", new {id= id});
        }

        public async Task GroupMessageCreate([FromBody]ChatViewModel gm)
        {
            var group =_context.SupportGroups.Include(it=>it.Received).Include(it=>it.ChatApplicationUsers).ThenInclude(it=>it.Received).Single(it=>it.Id.ToString().ToLower()==gm.receiver);
            var user = await _UserManager.GetUserAsync(User);
            Message message = new Message(){
                Id = Guid.NewGuid(),
                Content=gm.contentstring,
                DateTime=DateTime.Now,
                Sender= user,
                SenderId=user.Id,
                SupportGroup=group,
                GroupId=group.Id,
                Receivers=group.ChatApplicationUsers
            };
            group.Received.Add(message);
            _context.Update(group);
            foreach( var item in group.ChatApplicationUsers){
                item.Received.Add(message);
                _context.Update(item);    
            }
            _context.Add(message);
            await _context.SaveChangesAsync();
        }

        //Personal Chats
        public async Task<IActionResult> Hub(string id){
            if (_context.ChatApplicationUsers.Any(it=>it.UserName==id)){
                var target = await _context.ChatApplicationUsers.SingleAsync(it=>it.UserName==id);
                var user = await _UserManager.GetUserAsync(User);
                ViewBag.User= user;
                ViewBag.TargetFirstName= target.FirstName;
                ViewBag.TargetUsername = id;
                ViewBag.Messages = await GetChatMessages(id);

                return View();
            }
            else return NotFound();
        }

        public async Task<JsonResult> GetChats(){
            var user = await _context.ChatApplicationUsers.Include(it=>it.Received).ThenInclude(it=>it.SupportGroup).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));
            List<Guid> messages = new List<Guid>();
            var Chats = new List<ValueTuple<ChatApplicationUser,Message>>();
            if (user.Received!=null&& messages!=null){
                messages = user.Received.Where(it=>it.SupportGroup==null).Select(it=>it.Id).ToList();

                foreach (var u in _context.ChatApplicationUsers.Include(it=>it.Received).ThenInclude(it=>it.SupportGroup)){
                    if (u!=user&&u.Received.Where(it=>messages.Contains(it.Id)).Count()>0){
                        Chats.Add(new ValueTuple<ChatApplicationUser,Message>(u,(await GetChatMessages(u.UserName)).Last()));
                    }
                }
            }
            return Json(Chats.Select(it=>
                new {
                    id=it.Item1.UserName, 
                    name=it.Item1.FullName(),
                    lastmessage=it.Item2.Content,
                    DateTime=it.Item2.DateTime
                    }
                ).OrderByDescending(it=>it.DateTime)
            );
        }


        public async Task<IActionResult> NewPrivateChat(){
            var user = await _context.ChatApplicationUsers.Include(it=>it.SupportGroups).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));
            ViewBag.List = new SelectList(_context.ChatApplicationUsers.Where(it=>it.Received.Where(it=>it.Receivers.Contains(user)).Count()==0&&it.Id!=user.Id), "UserName", "FirstName");
            return View();
        }

        [HttpPost]
        public IActionResult NewPrivateChat(string username){
            return RedirectToAction(nameof(Hub),"Message", new {id= username});
        }

        public async Task<List<Message>> GetChatMessages(string username){
            var user = await _context.ChatApplicationUsers.Include(it=>it.Received).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));
            var target = await _context.ChatApplicationUsers.Include(it=>it.Received).SingleAsync(it=>it.UserName==username);
            
            List<Guid> messages = new List<Guid>();
            List<Message> result = new List<Message>();

            messages = user.Received.Where(it=>it.SupportGroup==null).Select(it=>it.Id).ToList();
            result.AddRange(target.Received.Where(it=>messages.Contains(it.Id)).OrderBy(it=>it.DateTime).ToList());

            return result;
        }

        public async Task PersonalMessageCreate([FromBody]ChatViewModel pm)
        {
            Message message = new Message(){
                Id = Guid.NewGuid(),
                Content=pm.contentstring,
                DateTime=DateTime.Now,
                Sender= await _UserManager.GetUserAsync(User)
            };
            _context.ChatApplicationUsers.Include(it=>it.Received).Single(it=>it.UserName==pm.sender).Received.Add(message);
            _context.ChatApplicationUsers.Include(it=>it.Received).Single(it=>it.UserName==pm.receiver).Received.Add(message);
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
        }
    
    }
}
