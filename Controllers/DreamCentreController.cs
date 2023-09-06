using Microsoft.AspNetCore.Mvc;

namespace LoveNottiesV2.Controllers
{
    public class DreamCentreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
