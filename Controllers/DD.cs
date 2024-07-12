using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class Hello : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
