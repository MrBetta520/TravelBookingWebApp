using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travel_V1.Models
{
    public class FlightReservation : Flight
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(10)]
        public int NumOfPassenger { get; set; }
        //[NotMapped]
        //public string ArrivalDate => ArrivalDateTime.ToString("MM/dd/yyyy");
        //[NotMapped]
        //public string ArrivaLTime => ArrivalDateTime.ToString("hh:mm tt");
        //[NotMapped]
        //public string DepartureDate => DepartureDateTime.ToString("MM/dd/yyyy");
        //[NotMapped]
        //public string DepartureTime => DepartureDateTime.ToString("hh:mm tt");
    }
}
