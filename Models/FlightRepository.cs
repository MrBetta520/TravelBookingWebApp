using System.Collections.Generic;

namespace Travel_V1.Models
{
    public class FlightRepository : IFlight
    {
        public List<Flight> Flights { get; set; }
        public FlightRepository()
        {
            Flights = new List<Flight>()
            {
                new Flight()
                {
                    Id = 1,
                    DepartureCity = "Newark",
                    DepartureAirport = "Liberty Intl. (EWR)",
                    ArrivalCity = "Cancun Intl. (CUN)",
                    ArrivalAirport = "Cancun",
                    Airline = "Spirit Airlines",
                    Price = 204,
                    Cabin = Cabin.Economy,
                    DepartureTime = "6:59pm",
                    ArrivalTime = "7:59am",
                    Duration = "14h 0m(2-Stop)"
                },
                new Flight()
                {
                    Id=2,
                    DepartureCity = "New York",
                    DepartureAirport = "LaGuardia (LGA)",
                    ArrivalCity = "Cancun",
                    ArrivalAirport = "Cancun Intl. (CUN)",
                    Airline = "Spirit Airlines",
                    Price = 204,
                    Cabin = Cabin.Economy,
                    DepartureTime = "5:59pm",
                    ArrivalTime = "11:36am",
                    Duration = "6h 37m(Nonstop)"
                },
                new Flight()
                {
                    Id = 3,
                    DepartureCity = "New York",
                    DepartureAirport = "LaGuardia (LGA)",
                    ArrivalCity = "Cancun",
                    ArrivalAirport = "Cancun Intl. (CUN)",
                    Airline = "Spirit Airlines",
                    Price = 204,
                    Cabin = Cabin.Economy,
                    DepartureTime = "7:59pm",
                    ArrivalTime = "7:36am",
                    Duration = "13h 0m(2-Stop)"
                },
                new Flight()
                {
                    Id = 4,
                    DepartureCity = "Newark",
                    DepartureAirport = "Liberty Intl. (EWR)",
                    ArrivalCity = "Cancun",
                    ArrivalAirport = "Cancun Intl. (CUN)",
                    Airline = "United",
                    Price = 284,
                    Cabin = Cabin.Economy,
                    DepartureTime = "7:59am",
                    ArrivalTime = "11:05am",
                    Duration = "4h 6m(Nonstop)"
                },
                new Flight()
                {
                    Id = 5,
                    DepartureCity = "Newark",
                    DepartureAirport = "Liberty Intl. (EWR)",
                    ArrivalCity = "Cancun",
                    ArrivalAirport = "Cancun Intl. (CUN)",
                    Airline = "JetBlue Airways",
                    Price = 289,
                    Cabin = Cabin.Economy,
                    DepartureTime = "7:24am",
                    ArrivalTime = "10:26am",
                    Duration = "4h 2m(Nonstop)"
                }
            };
        }

        public IEnumerable<Flight> InitializeFlight()
        {
            return Flights;
        }

        public Flight GetFlightById(int? id)
        {
            if(id == null)
                    {
                return null;
            }
            else
            {
                return Flights.Find(x => x.Id == id);
            }
        }

        public IEnumerable<Flight> GetSearchedFlights(string departCity, string arrivalCity)
        {
            List<Flight> temp = new List<Flight>();

            if (departCity == null && arrivalCity == null)
            {
                return null;
            }
            else
            {
                foreach(Flight flight in Flights)
                {
                    if(flight.DepartureCity.ToLower() == departCity.ToLower() && flight.ArrivalCity.ToLower() == arrivalCity.ToLower())
                    {
                        temp.Add(flight);
                    }
                }
            }
            return temp;
        }
    }
}
