using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using OkOk.Data;
using OkOk.Models;
using OkOk.Models.Identity;

namespace OkOk.Controllers
{
    [Authorize(Roles = "Doctor,Admin")]
    public class SignUpRequestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SignUpRequestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateRequestAsync(ClientApplicationUser clientApplicationUser)
        {
            if (ModelState.IsValid)
            {
                //get random value from totals in doctorapplicationusers
                Random rand = new Random();
                int toSkip = rand.Next(0, _context.DoctorApplicationUsers.Count());

                //get random doctor with less than 10 unhandled signuprequests
                DoctorApplicationUser doctorApplicationUser = _context.DoctorApplicationUsers.Include(doc => doc.SignUpRequests).Where(doc => doc.SignUpRequests.Where(sur => sur.Handled == false).Count() < 10).Skip(toSkip).Take(1).First();

                SignUpRequest signUpRequest = new SignUpRequest()
                {
                    Id = Guid.NewGuid(),
                    Handled = false,
                    ClientApplicationUser = clientApplicationUser,
                    DoctorApplicationUser = doctorApplicationUser
                };
                
                _context.Add(signUpRequest);
                await _context.SaveChangesAsync();
            }
        }

        // GET: SignUpRequest
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SignUpRequests.Include(s => s.ClientApplicationUser).Include(s => s.DoctorApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SignUpRequest/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signUpRequest = await _context.SignUpRequests
                .Include(s => s.ClientApplicationUser)
                .Include(s => s.DoctorApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (signUpRequest == null)
            {
                return NotFound();
            }

            return View(signUpRequest);
        }

        

        // GET: SignUpRequest/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
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
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Handled,ClientId,DoctorId")] SignUpRequest signUpRequest)
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

        // GET: SignUpRequest/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signUpRequest = await _context.SignUpRequests
                .Include(s => s.ClientApplicationUser)
                .Include(s => s.DoctorApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (signUpRequest == null)
            {
                return NotFound();
            }

            return View(signUpRequest);
        }

        // POST: SignUpRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var signUpRequest = await _context.SignUpRequests.FindAsync(id);
            _context.SignUpRequests.Remove(signUpRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SignUpRequestExists(Guid id)
        {
            return _context.SignUpRequests.Any(e => e.Id == id);
        }
    }
}
