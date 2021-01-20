using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dream_carMVC.Data;
using dream_carMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace dream_carMVC.Controllers
{
    public class ModelsController : Controller
    {
        private readonly dream_carMVCdatabase _context;

        public ModelsController(dream_carMVCdatabase context)
        {
            _context = context;
        }

        // GET: Models
        public async Task<IActionResult> Index()
        {
            var dream_carMVCdatabase = _context.Model.Include(m => m.Dealer);
            return View(await dream_carMVCdatabase.ToListAsync());
        }

        // GET: Models/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Model
                .Include(m => m.Dealer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
        [Authorize]// normal user cannot create data entry
        // GET: Models/Create
        public IActionResult Create()
        {
            ViewData["DealerId"] = new SelectList(_context.Dealer, "Id", "Dealer_Address");
            return View();
        }

        // POST: Models/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Model_Name,Model_Year,Company_Id,DealerId")] Model model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DealerId"] = new SelectList(_context.Dealer, "Id", "Dealer_Address", model.DealerId);
            return View(model);
        }
        [Authorize]// normal user cannot edit data entry
        // GET: Models/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Model.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            ViewData["DealerId"] = new SelectList(_context.Dealer, "Id", "Dealer_Address", model.DealerId);
            return View(model);
        }

        // POST: Models/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Model_Name,Model_Year,Company_Id,DealerId")] Model model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModelExists(model.Id))
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
            ViewData["DealerId"] = new SelectList(_context.Dealer, "Id", "Dealer_Address", model.DealerId);
            return View(model);
        }
        [Authorize]// normal user cannot delete data entry
        // GET: Models/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Model
                .Include(m => m.Dealer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Models/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await _context.Model.FindAsync(id);
            _context.Model.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModelExists(int id)
        {
            return _context.Model.Any(e => e.Id == id);
        }
    }
}
