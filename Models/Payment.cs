﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public int UserId { get; set; }

        public string Method { get; set; }

        public string Date { get; set; }

        public int ReservationId { get; set; }


        //"virtual" key word seems to be optional when doing foreign keys
        public virtual Reservation Reservation { get; set; }

        public virtual User User { get; set; }
    }
}
