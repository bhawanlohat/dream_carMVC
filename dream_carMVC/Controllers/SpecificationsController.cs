using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dream_carMVC.Data;
using dream_carMVC.Models;

namespace dream_carMVC.Controllers
{
    public class SpecificationsController : Controller
    {
        private readonly dream_carMVCdatabase _context;

        public SpecificationsController(dream_carMVCdatabase context)
        {
            _context = context;
        }

        // GET: Specifications
        public async Task<IActionResult> Index()
        {
            var dream_carMVCdatabase = _context.Specification.Include(s => s.Model);
            return View(await dream_carMVCdatabase.ToListAsync());
        }

        // GET: Specifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specification = await _context.Specification
                .Include(s => s.Model)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specification == null)
            {
                return NotFound();
            }

            return View(specification);
        }

        // GET: Specifications/Create
        public IActionResult Create()
        {
            ViewData["ModelId"] = new SelectList(_context.Model, "Id", "Model_Name");
            return View();
        }

        // POST: Specifications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fuel_type,Transmission,GPS,Rating,ModelId")] Specification specification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(specification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ModelId"] = new SelectList(_context.Model, "Id", "Model_Name", specification.ModelId);
            return View(specification);
        }

        // GET: Specifications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specification = await _context.Specification.FindAsync(id);
            if (specification == null)
            {
                return NotFound();
            }
            ViewData["ModelId"] = new SelectList(_context.Model, "Id", "Model_Name", specification.ModelId);
            return View(specification);
        }

        // POST: Specifications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fuel_type,Transmission,GPS,Rating,ModelId")] Specification specification)
        {
            if (id != specification.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecificationExists(specification.Id))
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
            ViewData["ModelId"] = new SelectList(_context.Model, "Id", "Model_Name", specification.ModelId);
            return View(specification);
        }

        // GET: Specifications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specification = await _context.Specification
                .Include(s => s.Model)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specification == null)
            {
                return NotFound();
            }

            return View(specification);
        }

        // POST: Specifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var specification = await _context.Specification.FindAsync(id);
            _context.Specification.Remove(specification);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecificationExists(int id)
        {
            return _context.Specification.Any(e => e.Id == id);
        }
    }
}
