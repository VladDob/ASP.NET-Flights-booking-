using FlightBooking.Models;
using FlightBooking.Repositories.Interfaces;

namespace FlightBooking.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _flightsContext;
        private IFlightsRepository? _flightsRepository;
        private ApplicationDbContext _reservationContext;
        private IReservationRepository? _reservationRepository;
        private ApplicationDbContext _paymentContext;
        private IPaymentRepository? _paymentRepository;

        public IFlightsRepository FlightsRepository
        {
            get
            {
                if (_flightsRepository == null)
                {
                    _flightsRepository = new FlightsRepository(_flightsContext);
                }

                return _flightsRepository;
            }
        }

        public IReservationRepository ReservationRepository
        {
            get
            {
                if (_reservationRepository == null)
                {
                    _reservationRepository = new ReservationRepository(_reservationContext);
                }

                return _reservationRepository;
            }
        }

        public IPaymentRepository PaymentRepository
        {
            get
            {
                if (_paymentRepository == null)
                {
                    _paymentRepository = new PaymentRepository(_paymentContext);
                }

                return _paymentRepository;
            }
        }

        public RepositoryWrapper(ApplicationDbContext flightsContext, ApplicationDbContext reservationContext, ApplicationDbContext paymentContext)
        {
            _flightsContext = flightsContext;
            _reservationContext = reservationContext;
            _paymentContext = paymentContext;
        }

        public void Save()
        {
            _flightsContext.SaveChanges();
            _reservationContext.SaveChanges();
            _paymentContext.SaveChanges();
        }
    }
}
