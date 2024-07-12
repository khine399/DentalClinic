using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class PendingController : Controller
    {
        public IActionResult PendingList()
        {
            return View("Pending");
        }
    }
}
