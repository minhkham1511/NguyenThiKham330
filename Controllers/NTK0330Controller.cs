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
    public class NTK0330Controller : Controller
    {
        private readonly LTQLDb _context;

        public NTK0330Controller(LTQLDb context)
        {
            _context = context;
        }

        // GET: NTK0330
        public async Task<IActionResult> Index()
        {
              return _context.NTK0330 != null ? 
                          View(await _context.NTK0330.ToListAsync()) :
                          Problem("Entity set 'LTQLDb.NTK0330'  is null.");
        }

        // GET: NTK0330/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NTK0330 == null)
            {
                return NotFound();
            }

            var nTK0330 = await _context.NTK0330
                .FirstOrDefaultAsync(m => m.NTKId == id);
            if (nTK0330 == null)
            {
                return NotFound();
            }

            return View(nTK0330);
        }

        // GET: NTK0330/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTK0330/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTKId,NTKName,NTKGender")] NTK0330 nTK0330)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTK0330);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTK0330);
        }

        // GET: NTK0330/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NTK0330 == null)
            {
                return NotFound();
            }

            var nTK0330 = await _context.NTK0330.FindAsync(id);
            if (nTK0330 == null)
            {
                return NotFound();
            }
            return View(nTK0330);
        }

        // POST: NTK0330/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NTKId,NTKName,NTKGender")] NTK0330 nTK0330)
        {
            if (id != nTK0330.NTKId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTK0330);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTK0330Exists(nTK0330.NTKId))
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
            return View(nTK0330);
        }

        // GET: NTK0330/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NTK0330 == null)
            {
                return NotFound();
            }

            var nTK0330 = await _context.NTK0330
                .FirstOrDefaultAsync(m => m.NTKId == id);
            if (nTK0330 == null)
            {
                return NotFound();
            }

            return View(nTK0330);
        }

        // POST: NTK0330/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.NTK0330 == null)
            {
                return Problem("Entity set 'LTQLDb.NTK0330'  is null.");
            }
            var nTK0330 = await _context.NTK0330.FindAsync(id);
            if (nTK0330 != null)
            {
                _context.NTK0330.Remove(nTK0330);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTK0330Exists(int id)
        {
          return (_context.NTK0330?.Any(e => e.NTKId == id)).GetValueOrDefault();
        }
    }
}
