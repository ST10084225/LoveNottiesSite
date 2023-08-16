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
    public class SuccessStoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuccessStoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SuccessStory
        public async Task<IActionResult> Index()
        {
            return View(await _context.successStories.ToListAsync());
        }

        // GET: SuccessStory/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var successStory = await _context.successStories
                .FirstOrDefaultAsync(m => m.SuccessStoryID == id);
            if (successStory == null)
            {
                return NotFound();
            }

            return View(successStory);
        }

        // GET: SuccessStory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SuccessStory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SuccessStoryID,SuccessStoryTitle,SuccessStoryImage,SuccessStoryDescription")] SuccessStory successStory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(successStory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(successStory);
        }

        // GET: SuccessStory/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var successStory = await _context.successStories.FindAsync(id);
            if (successStory == null)
            {
                return NotFound();
            }
            return View(successStory);
        }

        // POST: SuccessStory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SuccessStoryID,SuccessStoryTitle,SuccessStoryImage,SuccessStoryDescription")] SuccessStory successStory)
        {
            if (id != successStory.SuccessStoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(successStory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuccessStoryExists(successStory.SuccessStoryID))
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
            return View(successStory);
        }

        // GET: SuccessStory/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var successStory = await _context.successStories
                .FirstOrDefaultAsync(m => m.SuccessStoryID == id);
            if (successStory == null)
            {
                return NotFound();
            }

            return View(successStory);
        }

        // POST: SuccessStory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var successStory = await _context.successStories.FindAsync(id);
            _context.successStories.Remove(successStory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuccessStoryExists(string id)
        {
            return _context.successStories.Any(e => e.SuccessStoryID == id);
        }
    }
}
