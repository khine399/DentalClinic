using Microsoft.AspNetCore.Mvc;

namespace DentalClinicController.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }
    }
}
