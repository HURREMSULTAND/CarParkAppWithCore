using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Parking.MVC.Controllers
{
    [Area("Landing")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
