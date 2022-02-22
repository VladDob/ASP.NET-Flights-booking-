using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.Models
{
    public class Reservation
    {
        [Key]
        public int ID { get; set; }

        public string Class { get; set; }

        public string Date { get; set; }
        
        public int ReservedSeats { get; set; }
    }
}
