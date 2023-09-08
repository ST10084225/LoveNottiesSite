using System.Collections.Generic;

namespace LoveNottiesV2.Models.Repositories.Abstract
{
    public interface ISuccessStoryRepository
    {
        //get all of the success stories
        IEnumerable<SuccessStory> GetAllSuccessStories();
    }
}
