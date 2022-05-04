using System.Collections.Generic;

namespace Travel_V1.Models
{
    public interface IFlight
    {
        List<Flight> Flights { get; set; }
        IEnumerable<Flight> InitializeFlight();
        Flight GetFlightById(int? id);
        IEnumerable<Flight> GetSearchedFlights(string departCity, string arrivalCity);

    }
}
