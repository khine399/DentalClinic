using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class Patient : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
