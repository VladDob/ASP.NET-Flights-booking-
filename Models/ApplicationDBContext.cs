using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>  //: DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Flights> Flights { get; set; }

        public DbSet<Payment> Payment { get; set; }

        public DbSet<Reservation> Reservation { get; set; }

        public DbSet<ReservationForFlight> ReservationForFlight { get; set; }

    }
}
