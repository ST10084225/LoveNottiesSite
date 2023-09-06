using LoveNottiesV2.Data;
using LoveNottiesV2.Models.Repositories.Abstract;
using System.Collections.Generic;

namespace LoveNottiesV2.Models.Repositories.Implemented
{
    public class SuccessStoryRepository : ISuccessStoryRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IBlobService _IblobService;

        public SuccessStoryRepository(ApplicationDbContext context, IBlobService iblobService)
        {
            this._context = context;
            _IblobService = iblobService;
        }

        public IEnumerable<SuccessStory> GetAllSuccessStories()
        {
            var posts = _context.successStories;
            IEnumerable<SuccessStory> list = _context.successStories;
            foreach (var item in posts)
            {
                return list;
            }
            return list;
        }
    }
}
