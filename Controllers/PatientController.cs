using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult LogOT()
        {
            return View("logO");
        }
    }
}
