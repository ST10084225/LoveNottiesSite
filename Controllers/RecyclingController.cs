using Microsoft.AspNetCore.Mvc;

namespace LoveNottiesV2.Controllers
{
    public class RecyclingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
