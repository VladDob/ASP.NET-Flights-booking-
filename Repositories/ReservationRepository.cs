using FlightBooking.Models;
using FlightBooking.Repositories.Interfaces;

namespace FlightBooking.Repositories
{
    public class ReservationRepository : RepositoryBase<Reservation>, IReservationRepository
    {
        public ReservationRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
        }
    }
}
