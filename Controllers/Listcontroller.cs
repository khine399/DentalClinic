using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class Listcontroller : Controller
    {
        public IActionResult List()
        {
            return View("list");
        }
    }
}
