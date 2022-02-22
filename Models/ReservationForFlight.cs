using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.Models
{
    [Keyless]
    public class ReservationForFlight
    {
      
        public int FlightNumber { get; set; }
        public Flights Flight { get; set; }


        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }


    }
}
