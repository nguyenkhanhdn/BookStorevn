using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStorevn.Data;
using BookStorevn.Models;

namespace BookStorevn.Controllers
{
    public class StationeriesController : Controller
    {
        private readonly BookStoreContext _context;

        public StationeriesController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: Stationeries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stationeries.ToListAsync());
        }

        // GET: Stationeries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stationery = await _context.Stationeries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stationery == null)
            {
                return NotFound();
            }

            return View(stationery);
        }

        // GET: Stationeries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stationeries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Img,Quantity,Price")] Stationery stationery)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stationery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stationery);
        }

        // GET: Stationeries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stationery = await _context.Stationeries.FindAsync(id);
            if (stationery == null)
            {
                return NotFound();
            }
            return View(stationery);
        }

        // POST: Stationeries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Img,Quantity,Price")] Stationery stationery)
        {
            if (id != stationery.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stationery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StationeryExists(stationery.Id))
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
            return View(stationery);
        }

        // GET: Stationeries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stationery = await _context.Stationeries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stationery == null)
            {
                return NotFound();
            }

            return View(stationery);
        }

        // POST: Stationeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stationery = await _context.Stationeries.FindAsync(id);
            if (stationery != null)
            {
                _context.Stationeries.Remove(stationery);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StationeryExists(int id)
        {
            return _context.Stationeries.Any(e => e.Id == id);
        }
    }
}
