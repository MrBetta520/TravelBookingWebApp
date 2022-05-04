using Microsoft.EntityFrameworkCore;

namespace Travel_V1.Models
{
    public class FlightContext : DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options) : base(options)
        {

        }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>().HasData(
                new Flight()
                {
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
                    DepartureCity = "",
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
            );
        }
    }
}
