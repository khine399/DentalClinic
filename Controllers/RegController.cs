using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class RegController : Controller
    {
        public IActionResult Reg()
        {
            return View("Register");
        }
    }
}
