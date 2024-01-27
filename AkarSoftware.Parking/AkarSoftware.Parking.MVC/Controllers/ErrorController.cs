using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Parking.MVC.Controllers
{
    public class ErrorController : Controller
    {
        [Route("error")]
        public IActionResult Hata(int code)
        {
            return View();
        }

        [Route("exception")]
        public IActionResult Hata()
        {
            return View();
        }
    }
}
