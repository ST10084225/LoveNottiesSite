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
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Blog
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogItems.ToListAsync());
        }

        // GET: Blog/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogItem = await _context.BlogItems
                .FirstOrDefaultAsync(m => m.BlogID == id);
            if (blogItem == null)
            {
                return NotFound();
            }

            blogItem.BlogViews = (Convert.ToInt32(blogItem.BlogViews) + 1).ToString();
            await _context.SaveChangesAsync();

            return View(blogItem);
        }

        // GET: Blog/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlogID,BlogImage,BlogDescription,BlogViews")] BlogItem blogItem)
        {
            if (ModelState.IsValid)
            {
                //Set the Blog View Counter to 0
                blogItem.BlogViews = "0";

                //Get the most recent blog's ID, and add 1
                var blogList = await _context.BlogItems.ToListAsync();
                var lastBlog = blogList.LastOrDefault();
                if (lastBlog != null)
                {
                    blogItem.BlogID = (Convert.ToInt32(lastBlog.BlogID) + 1).ToString();
                }
                else
                {
                    blogItem.BlogID = "1";
                }

                _context.Add(blogItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogItem);
        }

        // GET: Blog/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogItem = await _context.BlogItems.FindAsync(id);
            if (blogItem == null)
            {
                return NotFound();
            }
            return View(blogItem);
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("BlogID,BlogTitle,BlogImage,BlogDescription,BlogTag,BlogViews")] BlogItem blogItem)
        {
            if (id != blogItem.BlogID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogItemExists(blogItem.BlogID))
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
            return View(blogItem);
        }

        // GET: Blog/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogItem = await _context.BlogItems
                .FirstOrDefaultAsync(m => m.BlogID == id);
            if (blogItem == null)
            {
                return NotFound();
            }

            return View(blogItem);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var blogItem = await _context.BlogItems.FindAsync(id);
            _context.BlogItems.Remove(blogItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogItemExists(string id)
        {
            return _context.BlogItems.Any(e => e.BlogID == id);
        }
    }
}
