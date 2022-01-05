using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OkOk.Data;
using OkOk.Models;

namespace OkOk.Controllers
{
    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<MessageController> _logger;

        public MessageController(ILogger<MessageController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Message
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Messages.Include(m => m.ChatApplicationUser).Include(m => m.SupportGroup);
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
                .Include(m => m.ChatApplicationUser)
                .Include(m => m.SupportGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // GET: Message/Create
        public IActionResult Create()
        {
            ViewData["ChatUserId"] = new SelectList(_context.ChatApplicationUsers, "Id", "Id");
            ViewData["GroupId"] = new SelectList(_context.SupportGroups, "Id", "Description");
            return View();
        }

        // POST: Message/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Content,DateTime,ChatUserId,GroupId")] Message message)
        {
            if (ModelState.IsValid)
            {
                message.Id = Guid.NewGuid();
                _context.Add(message);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChatUserId"] = new SelectList(_context.ChatApplicationUsers, "Id", "Id", message.ChatUserId);
            ViewData["GroupId"] = new SelectList(_context.SupportGroups, "Id", "Description", message.GroupId);
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
            ViewData["ChatUserId"] = new SelectList(_context.ChatApplicationUsers, "Id", "Id", message.ChatUserId);
            ViewData["GroupId"] = new SelectList(_context.SupportGroups, "Id", "Description", message.GroupId);
            return View(message);
        }

        // POST: Message/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Content,DateTime,ChatUserId,GroupId")] Message message)
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
            ViewData["ChatUserId"] = new SelectList(_context.ChatApplicationUsers, "Id", "Id", message.ChatUserId);
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
                .Include(m => m.ChatApplicationUser)
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
