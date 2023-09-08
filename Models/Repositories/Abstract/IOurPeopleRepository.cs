using System.Collections.Generic;

namespace LoveNottiesV2.Models.Repositories.Abstract
{
    public interface IOurPeopleRepository
    {
        //get all of our people
        IEnumerable<OurPeople> GetAllOurPeople();
    }
}
