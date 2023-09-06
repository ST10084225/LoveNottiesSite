using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoveNottiesV2.Data;
using LoveNottiesV2.Models;
using LoveNottiesV2.Models.Repositories.Abstract;
using Azure.Storage.Blobs.Models;
using System.IO;

namespace LoveNottiesV2.Controllers
{
    public class SuccessStoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBlobService _IBlobService;
        private readonly ISuccessStoryRepository _ISuccessStoryRepository;

        public SuccessStoryController(ApplicationDbContext context, IBlobService IBlobService, ISuccessStoryRepository iSuccessStoryRepository)
        {
            _context = context;
            _IBlobService = IBlobService;
            _ISuccessStoryRepository = iSuccessStoryRepository;
        }

        // GET: SuccessStory
        public async Task<IActionResult> Index()
        {
            return View(_ISuccessStoryRepository.GetAllSuccessStories());
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
        public async Task<IActionResult> Create([Bind("SuccessStoryID,SuccessStoryTitle,SuccessStoryImageID,SuccessStoryDescription," +
            "SuccessStoryImageFile")] SuccessStory successStory)
        {
            if (ModelState.IsValid)
            {
                //Get the most recent blog's ID, and add 1
                var successStoryList = await _context.successStories.ToListAsync();
                var lastStory = successStoryList.LastOrDefault();
                if (lastStory != null)
                {
                    successStory.SuccessStoryID = (Convert.ToInt32(lastStory.SuccessStoryID) + 1).ToString();
                    successStory.SuccessStoryImageID = (Convert.ToInt32(lastStory.SuccessStoryID) + 1).ToString();
                }
                else
                {
                    successStory.SuccessStoryID = "1";
                    successStory.SuccessStoryImageID = "1";
                }

                byte[] fileByteArray;    //1st change here
                if (successStory.SuccessStoryImageFile != null)
                {
                    using (var item = new MemoryStream())
                    {
                        successStory.SuccessStoryImageFile.CopyTo(item);
                        fileByteArray = item.ToArray(); //2nd change here

                        if (_IBlobService.DoesBlobExists(successStory.SuccessStoryImageID, BlobContainer.successimages).Result == false)
                        {
                            await _IBlobService.UploadFileBlobAsync(fileByteArray, successStory.SuccessStoryImageID, BlobContainer.successimages);
                        }
                    }
                }
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
