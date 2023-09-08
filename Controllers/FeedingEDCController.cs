using Microsoft.AspNetCore.Mvc;

namespace LoveNottiesV2.Controllers
{
    public class FeedingEDCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
