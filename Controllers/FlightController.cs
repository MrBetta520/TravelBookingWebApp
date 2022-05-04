using Microsoft.AspNetCore.Mvc;
using Travel_V1.Models;
using Microsoft.AspNetCore.Authorization;

namespace Travel_V1.Controllers
{
    public class FlightController : Controller
    {
        private IFlight _Flight;
        public FlightController(IFlight flight)
        {
            _Flight = flight;
        }
        public IActionResult Index()
        {
            FlightViewModel model = new FlightViewModel();
            model.Flights = _Flight.InitializeFlight();
            return View(model);
        }

        public IActionResult MatchedFlights(string departureCity, string arrivalCity)
        {
            FlightViewModel model = new FlightViewModel();
            model.Flights = _Flight.GetSearchedFlights(departureCity, arrivalCity); 
            if(model == null)
            {
                return NoContent();
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult PaymentInfo(int? id)
        {
            var model = _Flight.GetFlightById(id);
            if(model == null)
            {
                return NotFound();
            }
            else
            {
                return View(model);
            }
        }
    }
}
