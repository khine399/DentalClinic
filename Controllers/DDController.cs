using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class DDController : Controller
    {
        public IActionResult Clinic()
        {
            return View("nwe");
        }
    }
}
