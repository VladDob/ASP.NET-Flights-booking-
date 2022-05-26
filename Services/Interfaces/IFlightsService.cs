using FlightBooking.Models;
using System.Collections.Generic;

namespace FlightBooking.Services.Interfaces
{
    public interface IFlightsService
    {
        //List<Flights> GetFlightsByType(string FlightsType);
        List<Flights> GetFlights();
        void AddFlights(Flights flight);
        void RemoveFlights(Flights flight);
    }
}
