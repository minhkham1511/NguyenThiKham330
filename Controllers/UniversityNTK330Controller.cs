using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenThiKham330.Model;

namespace NguyenThiKham330.Controllers
{
    public class UniversityNTK330Controller : Controller
    {
        private readonly LTQLDb _context;

        public UniversityNTK330Controller(LTQLDb context)
        {
            _context = context;
        }

        // GET: UniversityNTK330
        public async Task<IActionResult> Index()
        {
              return _context.UniversityNTK330 != null ? 
                          View(await _context.UniversityNTK330.ToListAsync()) :
                          Problem("Entity set 'LTQLDb.UniversityNTK330'  is null.");
        }

        // GET: UniversityNTK330/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.UniversityNTK330 == null)
            {
                return NotFound();
            }

            var universityNTK330 = await _context.UniversityNTK330
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNTK330 == null)
            {
                return NotFound();
            }

            return View(universityNTK330);
        }

        // GET: UniversityNTK330/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityNTK330/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityNTK330 universityNTK330)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityNTK330);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityNTK330);
        }

        // GET: UniversityNTK330/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.UniversityNTK330 == null)
            {
                return NotFound();
            }

            var universityNTK330 = await _context.UniversityNTK330.FindAsync(id);
            if (universityNTK330 == null)
            {
                return NotFound();
            }
            return View(universityNTK330);
        }

        // POST: UniversityNTK330/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityNTK330 universityNTK330)
        {
            if (id != universityNTK330.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityNTK330);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityNTK330Exists(universityNTK330.UniversityId))
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
            return View(universityNTK330);
        }

        // GET: UniversityNTK330/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.UniversityNTK330 == null)
            {
                return NotFound();
            }

            var universityNTK330 = await _context.UniversityNTK330
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNTK330 == null)
            {
                return NotFound();
            }

            return View(universityNTK330);
        }

        // POST: UniversityNTK330/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.UniversityNTK330 == null)
            {
                return Problem("Entity set 'LTQLDb.UniversityNTK330'  is null.");
            }
            var universityNTK330 = await _context.UniversityNTK330.FindAsync(id);
            if (universityNTK330 != null)
            {
                _context.UniversityNTK330.Remove(universityNTK330);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityNTK330Exists(string id)
        {
          return (_context.UniversityNTK330?.Any(e => e.UniversityId == id)).GetValueOrDefault();
        }
    }
}
