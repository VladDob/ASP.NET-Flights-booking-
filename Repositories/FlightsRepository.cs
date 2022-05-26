using FlightBooking.Models;
using FlightBooking.Repositories.Interfaces;

namespace FlightBooking.Repositories
{
    public class FlightsRepository : RepositoryBase<Flights>, IFlightsRepository
    {
        public FlightsRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
        }
    }
}
