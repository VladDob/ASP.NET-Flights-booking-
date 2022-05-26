using FlightBooking.Models;
using System.Collections.Generic;

namespace FlightBooking.Services.Interfaces
{
    public interface IReservationService
    {
        List<Reservation> GetReservation();
    }
}
