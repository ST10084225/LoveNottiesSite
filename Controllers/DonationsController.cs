using Microsoft.AspNetCore.Mvc;

namespace LoveNottiesV2.Controllers
{
    public class DonationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
