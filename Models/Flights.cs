using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.Models
{
    public class Flights
    {
        [Key]
        public int Number { get; set; }

        public string Departure { get; set; }
      
        public string Arrival { get; set; }

        public int Capacity { get; set; }

        public string Departure_time { get; set; }

        public string Arrival_time { get; set; }

        public string Departure_date { get; set; }

        public string Arrival_date { get; set; }

        public string Plane_type { get; set; }

    }
}
