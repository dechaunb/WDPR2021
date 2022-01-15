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

namespace OkOk.Controllers
{
    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signinmanager;
        private readonly UserManager<ChatApplicationUser> _UserManager;
        
        public MessageController(ApplicationDbContext context, SignInManager<ApplicationUser> signInManager, UserManager<ChatApplicationUser> userManager)
        {
            _context = context;
            _signinmanager = signInManager;
            _UserManager = userManager;
        }

        public async Task<IActionResult> Hub(string id){
            var user = await _UserManager.GetUserAsync(User);
            ViewBag.User= user;
            ViewBag.TargetFirstName= (await _context.ChatApplicationUsers.SingleAsync(it=>it.UserName==id)).FirstName;
            ViewBag.TargetUsername = id;
            ViewBag.TargetId = (await _context.ChatApplicationUsers.SingleAsync(it=>it.UserName==id)).Id;;
            ViewBag.Messages = await GetChatMessages(id);

            return View();
        }

        //GET:GroupChats
        public JsonResult GetGroupChats(){
            var userId = _UserManager.GetUserId(User);
            ChatApplicationUser user =  _context.ChatApplicationUsers.Include(it=>it.SupportGroups).Single(it=>it.Id==userId);

            List<SupportGroup> groupchats = user.SupportGroups.ToList();

            return Json(groupchats);
        }

        public async Task<IActionResult> Chats(){
            return View(await GetChats());
        }

        //GET:Chats
        public async Task<JsonResult> GetChats(){
            var user = await _context.ChatApplicationUsers.Include(it=>it.Received).ThenInclude(it=>it.SupportGroup).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));
            List<Guid> messages = new List<Guid>();
            var Chats = new List<ChatApplicationUser>();
            if (user.Received!=null&& messages!=null){
                messages = user.Received.Where(it=>it.SupportGroup==null).Select(it=>it.Id).ToList();

                foreach (var u in _context.ChatApplicationUsers.Include(it=>it.Received).ThenInclude(it=>it.SupportGroup)){
                    if (u!=user&&u.Received.Where(it=>messages.Contains(it.Id)).Count()>0){
                        Chats.Add(u);
                    }
                }
            }
            return Json(Chats.Select(it=>it.UserName));
        }

        // public async Task<IActionResult> NewPrivateChat(){
        //     var user = await _context.ChatApplicationUsers.Include(it=>it.SupportGroups).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));
        //     ViewData["Receivers"] = new SelectList(_context.ChatApplicationUsers.Where(it=>it.Received.Where(it=>it.Receivers.Contains(user)).Count()!=0), "Id", "FirstName");
        //     return View();
        // }


        //GET:Chats
        public async Task<List<Message>> GetChatMessages(string username){
            var user = await _context.ChatApplicationUsers.Include(it=>it.Received).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));
            var target = await _context.ChatApplicationUsers.Include(it=>it.Received).SingleAsync(it=>it.UserName==username);
            Console.WriteLine(user.FirstName+target.FirstName);
            
            List<Guid> messages = new List<Guid>();
            List<Message> result = new List<Message>();

            messages = user.Received.Where(it=>it.SupportGroup==null).Select(it=>it.Id).ToList();
            result.AddRange(target.Received.Where(it=>messages.Contains(it.Id)).OrderBy(it=>it.DateTime).ToList());

            return result;
        }

        public async Task PersonalMessageCreate(string contentstring, string receiver, string sender)
        {
            Console.WriteLine(contentstring+" to "+receiver);
            Message message = new Message(){
                Id = Guid.NewGuid(),
                Content=contentstring,
                DateTime=DateTime.Now,
                Sender= await _UserManager.GetUserAsync(User)
            };
            _context.ChatApplicationUsers.Include(it=>it.Received).Single(it=>it.UserName==sender).Received.Add(message);
            _context.ChatApplicationUsers.Include(it=>it.Received).Single(it=>it.UserName==receiver).Received.Add(message);

            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
        }

        // GET: Message
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Messages.Include(m => m.Sender).Include(m => m.SupportGroup);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Message/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await _context.Messages
                .Include(m => m.Sender)
                .Include(m => m.SupportGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // GET: Message/Create
        public async Task<IActionResult> Create()
        {
            var sender = await _context.ChatApplicationUsers.Include(it=>it.SupportGroups).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));
            ViewData["ReceiverId"] = new SelectList(_context.ChatApplicationUsers.Where(it=>it.Received.Where(it=>it.Receivers.Contains(sender)).Count()!=0), "Id", "FirstName");
            ViewData["SenderId"]=sender.Id;
            return View();
        }

        // POST: Message/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Content,DateTime,SenderId,Receivers")] Message message)
        {
            var sender = await _context.ChatApplicationUsers.Include(it=>it.SupportGroups).SingleAsync(it=>it.Id== _UserManager.GetUserId(User));

            if (ModelState.IsValid)
            {
                message.Receivers.Add(sender);
                message.Id = Guid.NewGuid();
                _context.Add(message);
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Chats));
            }
            ViewData["ReceiverId"] = new SelectList(_context.ChatApplicationUsers.Where(it=>it.Received.Where(it=>it.Receivers.Contains(sender)).Count()==0), "Id", "FirstName");
            ViewData["SenderId"]=sender.Id;
            return View(message);
        }

        // GET: Message/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await _context.Messages.FindAsync(id);
            if (message == null)
            {
                return NotFound();
            }
            ViewData["SenderId"] = new SelectList(_context.ChatApplicationUsers, "Id", "Id", message.SenderId);
            ViewData["GroupId"] = new SelectList(_context.SupportGroups, "Id", "Description", message.GroupId);
            return View(message);
        }

        // POST: Message/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Content,DateTime,SenderId,GroupId")] Message message)
        {
            if (id != message.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(message);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MessageExists(message.Id))
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
            ViewData["SenderId"] = new SelectList(_context.ChatApplicationUsers, "Id", "Id", message.SenderId);
            ViewData["GroupId"] = new SelectList(_context.SupportGroups, "Id", "Description", message.GroupId);
            return View(message);
        }

        // GET: Message/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await _context.Messages
                .Include(m => m.Sender)
                .Include(m => m.SupportGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // POST: Message/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var message = await _context.Messages.FindAsync(id);
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MessageExists(Guid id)
        {
            return _context.Messages.Any(e => e.Id == id);
        }
    }
}
