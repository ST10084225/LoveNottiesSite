using LoveNottiesV2.Models.Repositories.Abstract;
using LoveNottiesV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Threading.Tasks;
using System;
using LoveNottiesV2.Data;
using System.Linq;

namespace LoveNottiesV2.Controllers
{
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IBlobService _IBlobService;
        private readonly IBlogRepository _IBlogRepository;

        public AdminController(ApplicationDbContext context, IBlobService IBlobService, IBlogRepository iBlogRepository)
        {
            _context = context;
            _IBlobService = IBlobService;
            _IBlogRepository = iBlogRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        // POST: Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBlog([Bind("BlogImageFile")] AdminModel admin)
        {
            if (ModelState.IsValid)
            {

                //find and delete the blog image
                if (_IBlobService.DoesBlobExists("BgBlog", BlobContainer.backgroundimages).Result == true)
                {
                    await _IBlobService.DeleteFromBlob("BgBlog", BlobContainer.backgroundimages);
                }

          

                byte[] fileByteArray;    //1st change here
                if (admin.BlogImageFile != null)
                {
                    using (var item = new MemoryStream())
                    {
                        admin.BlogImageFile.CopyTo(item);
                        fileByteArray = item.ToArray(); //2nd change here

                        if (_IBlobService.DoesBlobExists("BgBlog", BlobContainer.backgroundimages).Result == false)
                        {
                            await _IBlobService.UploadFileBlobAsync(fileByteArray, "BgBlog", BlobContainer.backgroundimages);
                        }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //return to index
            return RedirectToAction(nameof(Index));
        }

        // POST: Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditOP([Bind("OPImageFile")] AdminModel admin)
        {
            if (ModelState.IsValid)
            {

                //find and delete the blog image
                if (_IBlobService.DoesBlobExists("BgOP", BlobContainer.backgroundimages).Result == true)
                {
                    await _IBlobService.DeleteFromBlob("BgOP", BlobContainer.backgroundimages);
                }



                byte[] fileByteArray;    //1st change here
                if (admin.OPImageFile != null)
                {
                    using (var item = new MemoryStream())
                    {
                        admin.OPImageFile.CopyTo(item);
                        fileByteArray = item.ToArray(); //2nd change here

                        if (_IBlobService.DoesBlobExists("BgOP", BlobContainer.backgroundimages).Result == false)
                        {
                            await _IBlobService.UploadFileBlobAsync(fileByteArray, "BgOP", BlobContainer.backgroundimages);
                        }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //return to index
            return RedirectToAction(nameof(Index));
        }

        // POST: Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSS([Bind("SSImageFile")] AdminModel admin)
        {
            if (ModelState.IsValid)
            {

                //find and delete the blog image
                if (_IBlobService.DoesBlobExists("BgSS", BlobContainer.backgroundimages).Result == true)
                {
                    await _IBlobService.DeleteFromBlob("BgSS", BlobContainer.backgroundimages);
                }



                byte[] fileByteArray;    //1st change here
                if (admin.SSImageFile != null)
                {
                    using (var item = new MemoryStream())
                    {
                        admin.SSImageFile.CopyTo(item);
                        fileByteArray = item.ToArray(); //2nd change here

                        if (_IBlobService.DoesBlobExists("BgSS", BlobContainer.backgroundimages).Result == false)
                        {
                            await _IBlobService.UploadFileBlobAsync(fileByteArray, "BgSS", BlobContainer.backgroundimages);
                        }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //return to index
            return RedirectToAction(nameof(Index));
        }
    }
}
