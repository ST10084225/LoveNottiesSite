using LoveNottiesV2.Data;
using LoveNottiesV2.Models.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace LoveNottiesV2.Models.Repositories.Implemented
{
    public class BlogRepository : IBlogRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly IBlobService _IblobService;

        public BlogRepository(ApplicationDbContext context, IBlobService iblobService)
        {
            this._context = context;
            _IblobService = iblobService;
        }

        public IEnumerable<BlogItem> GetAllBlogPosts()
        {
            var posts = _context.BlogItems;
            IEnumerable<BlogItem> list = _context.BlogItems;
            foreach (var item in posts)
            {
                
                /*posts. = _IblobService.GetFileBlobAsync(item.BlogImageID, BlobContainer.blogimages).Result;*/
                return list;
            }
            return list;
        }

    }
}
