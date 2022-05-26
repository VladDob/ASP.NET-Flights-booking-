namespace FlightBooking.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IFlightsRepository FlightsRepository { get; }
        IReservationRepository ReservationRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        void Save();
    }
}
