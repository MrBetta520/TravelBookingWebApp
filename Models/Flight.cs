
using System;

namespace Travel_V1.Models
{
    public enum Cabin
    {
        Economy,
        Business,
        First
    }
    public class Flight
    {
        public int Id { get; set; }
        public string DepartureCity { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalCity { get; set; }
        public string ArrivalAirport { get; set; }
        public string DepartureTime { get; set; } 
        public string ArrivalTime { get; set; } 
        public decimal Price { get; set; }
        public string Airline { get; set; }
        public string Duration { get; set; }
        public Cabin Cabin { get; set; }
    }
}
