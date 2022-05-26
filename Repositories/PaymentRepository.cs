using FlightBooking.Models;
using FlightBooking.Repositories.Interfaces;

namespace FlightBooking.Repositories
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
        }
    }
}
