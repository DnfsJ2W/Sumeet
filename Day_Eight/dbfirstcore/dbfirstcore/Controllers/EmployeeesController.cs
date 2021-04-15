using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dbfirstcore.Models;

namespace dbfirstcore.Controllers
{
    public class EmployeeesController : Controller
    {
        private readonly employeedbContext _context;

        public EmployeeesController(employeedbContext context)
        {
            _context = context;
        }

        // GET: Employeees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employeees.ToListAsync());
        }

        // GET: Employeees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeee = await _context.Employeees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeee == null)
            {
                return NotFound();
            }

            return View(employeee);
        }

        // GET: Employeees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employeees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ename,Salary")] Employeee employeee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeee);
        }

        // GET: Employeees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeee = await _context.Employeees.FindAsync(id);
            if (employeee == null)
            {
                return NotFound();
            }
            return View(employeee);
        }

        // POST: Employeees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ename,Salary")] Employeee employeee)
        {
            if (id != employeee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeeExists(employeee.Id))
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
            return View(employeee);
        }

        // GET: Employeees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeee = await _context.Employeees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeee == null)
            {
                return NotFound();
            }

            return View(employeee);
        }

        // POST: Employeees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeee = await _context.Employeees.FindAsync(id);
            _context.Employeees.Remove(employeee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeeExists(int id)
        {
            return _context.Employeees.Any(e => e.Id == id);
        }
    }
}
