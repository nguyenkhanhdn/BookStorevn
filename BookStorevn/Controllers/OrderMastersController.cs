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
    public class OrderMastersController : Controller
    {
        private readonly BookStoreContext _context;

        public OrderMastersController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: OrderMasters
        public async Task<IActionResult> Index()
        {
            var bookStoreContext = _context.OrderMasters.Include(o => o.Customer);
            return View(await bookStoreContext.ToListAsync());
        }

        // GET: OrderMasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderMaster = await _context.OrderMasters
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderMaster == null)
            {
                return NotFound();
            }

            return View(orderMaster);
        }

        // GET: OrderMasters/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
            return View();
        }

        // POST: OrderMasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrderDate,CustomerId,ContactPerson,Address,Phone,EmployeeId")] OrderMaster orderMaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", orderMaster.CustomerId);
            return View(orderMaster);
        }

        // GET: OrderMasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderMaster = await _context.OrderMasters.FindAsync(id);
            if (orderMaster == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", orderMaster.CustomerId);
            return View(orderMaster);
        }

        // POST: OrderMasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrderDate,CustomerId,ContactPerson,Address,Phone,EmployeeId")] OrderMaster orderMaster)
        {
            if (id != orderMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderMasterExists(orderMaster.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", orderMaster.CustomerId);
            return View(orderMaster);
        }

        // GET: OrderMasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderMaster = await _context.OrderMasters
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderMaster == null)
            {
                return NotFound();
            }

            return View(orderMaster);
        }

        // POST: OrderMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderMaster = await _context.OrderMasters.FindAsync(id);
            if (orderMaster != null)
            {
                _context.OrderMasters.Remove(orderMaster);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderMasterExists(int id)
        {
            return _context.OrderMasters.Any(e => e.Id == id);
        }
    }
}
