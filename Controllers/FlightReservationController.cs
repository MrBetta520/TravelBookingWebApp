using Microsoft.AspNetCore.Mvc;

namespace Travel_V1.Controllers
{
    public class FlightReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
