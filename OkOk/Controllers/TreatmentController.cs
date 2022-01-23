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
    public class TreatmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TreatmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Treatment
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Treatments.Include(t => t.ClientApplicationUser).Include(t => t.DoctorApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Treatment/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var treatment = await _context.Treatments
                .Include(t => t.ClientApplicationUser)
                .Include(t => t.DoctorApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (treatment == null)
            {
                return NotFound();
            }

            return View(treatment);
        }

        // GET: Treatment/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.ClientApplicationUsers, "Id", "Id");
            ViewData["DoctorId"] = new SelectList(_context.DoctorApplicationUsers, "Id", "Id");
            return View();
        }

        // POST: Treatment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTime,Description,ClientId,DoctorId")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                treatment.Id = Guid.NewGuid();
                _context.Add(treatment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.ClientApplicationUsers, "Id", "Id", treatment.ClientId);
            ViewData["DoctorId"] = new SelectList(_context.DoctorApplicationUsers, "Id", "Id", treatment.DoctorId);
            return View(treatment);
        }

        // GET: Treatment/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var treatment = await _context.Treatments.FindAsync(id);
            if (treatment == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.ClientApplicationUsers, "Id", "Id", treatment.ClientId);
            ViewData["DoctorId"] = new SelectList(_context.DoctorApplicationUsers, "Id", "Id", treatment.DoctorId);
            return View(treatment);
        }

        // POST: Treatment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,DateTime,Description,ClientId,DoctorId")] Treatment treatment)
        {
            if (id != treatment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(treatment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TreatmentExists(treatment.Id))
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
            ViewData["ClientId"] = new SelectList(_context.ClientApplicationUsers, "Id", "Id", treatment.ClientId);
            ViewData["DoctorId"] = new SelectList(_context.DoctorApplicationUsers, "Id", "Id", treatment.DoctorId);
            return View(treatment);
        }

        // GET: Treatment/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var treatment = await _context.Treatments
                .Include(t => t.ClientApplicationUser)
                .Include(t => t.DoctorApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (treatment == null)
            {
                return NotFound();
            }

            return View(treatment);
        }

        // POST: Treatment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var treatment = await _context.Treatments.FindAsync(id);
            _context.Treatments.Remove(treatment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TreatmentExists(Guid id)
        {
            return _context.Treatments.Any(e => e.Id == id);
        }
    }
}
