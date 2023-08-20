using System.Collections.Generic;

namespace LoveNottiesV2.Models.Repositories.Abstract
{
    public interface IBlogRepository
    {
        //get all products currently on site
        IEnumerable<BlogItem> GetAllBlogPosts();
    }
}
