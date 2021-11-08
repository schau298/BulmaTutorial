using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BulmaTutorial.Models;

namespace BulmaTutorial.Views.BulmaExample
{
    public class BulmaExampleController : Controller
    {
        private readonly ExampleContext _context;

        public int ID { get; private set; }

        public BulmaExampleController(ExampleContext context)
        {
            _context = context;
        }

        // GET: BulmaExample
        public async Task<IActionResult> Index()
        {
            return View(await _context.Foods.ToListAsync());
        }

        // GET: BulmaExample/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bulmaExample = await _context.Foods
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bulmaExample == null)
            {
                return NotFound();
            }

            return View(bulmaExample);
        }

        // GET: BulmaExample/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BulmaExample/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Food,Category,Brand,Cost")] BulmaExampleController bulmaExample)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bulmaExample);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bulmaExample);
        }

        // GET: BulmaExample/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bulmaExample = await _context.Foods.FindAsync(id);
            if (bulmaExample == null)
            {
                return NotFound();
            }
            return View(bulmaExample);
        }

        // POST: BulmaExample/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Food,Category,Brand,Cost")] BulmaExampleController bulmaExample)
        {
            if (id != bulmaExample.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bulmaExample);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BulmaExampleExists(bulmaExample.ID))
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
            return View(bulmaExample);
        }

        // GET: BulmaExample/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bulmaExample = await _context.Foods
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bulmaExample == null)
            {
                return NotFound();
            }

            return View(bulmaExample);
        }

        // POST: BulmaExample/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bulmaExample = await _context.Foods.FindAsync(id);
            _context.Foods.Remove(bulmaExample);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BulmaExampleExists(int id)
        {
            return _context.Foods.Any(e => e.ID == id);
        }
    }
}
