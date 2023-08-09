using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoveNottiesV2.Data;
using LoveNottiesV2.Models;

namespace LoveNottiesV2.Controllers
{
    public class OurPeopleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OurPeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OurPeople
        public async Task<IActionResult> Index()
        {
            return View(await _context.OurPeoples.ToListAsync());
        }

        // GET: OurPeople/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourPeople = await _context.OurPeoples
                .FirstOrDefaultAsync(m => m.OurPersonID == id);
            if (ourPeople == null)
            {
                return NotFound();
            }

            return View(ourPeople);
        }

        // GET: OurPeople/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OurPeople/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OurPersonID,OurPersonFirstName,OurPersonLastName,OurPersonTitle,OurPersonImage,OurPersonDescription")] OurPeople ourPeople)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ourPeople);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ourPeople);
        }

        // GET: OurPeople/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourPeople = await _context.OurPeoples.FindAsync(id);
            if (ourPeople == null)
            {
                return NotFound();
            }
            return View(ourPeople);
        }

        // POST: OurPeople/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("OurPersonID,OurPersonFirstName,OurPersonLastName,OurPersonTitle,OurPersonImage,OurPersonDescription")] OurPeople ourPeople)
        {
            if (id != ourPeople.OurPersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ourPeople);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OurPeopleExists(ourPeople.OurPersonID))
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
            return View(ourPeople);
        }

        // GET: OurPeople/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourPeople = await _context.OurPeoples
                .FirstOrDefaultAsync(m => m.OurPersonID == id);
            if (ourPeople == null)
            {
                return NotFound();
            }

            return View(ourPeople);
        }

        // POST: OurPeople/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ourPeople = await _context.OurPeoples.FindAsync(id);
            _context.OurPeoples.Remove(ourPeople);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OurPeopleExists(string id)
        {
            return _context.OurPeoples.Any(e => e.OurPersonID == id);
        }
    }
}
