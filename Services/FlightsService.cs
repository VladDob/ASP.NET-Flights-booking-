using FlightBooking.Models;
using FlightBooking.Repositories.Interfaces;
using FlightBooking.Services.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;

namespace FlightBooking.Services
{
    public class FlightsService : IFlightsService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public FlightsService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        /*
        public List<Flights> GetFlightsByType(string FlightsType)
        {
            var Flights = new List<Flights>();

            if (FlightsType == "numeric_Flights")
            {
                Flights = _repositoryWrapper.FlightsRepository.FindByCondition(l => l.IsNumber == true).ToList();
            }
            else if (FlightsType == "textual_Flights")
            {
                Flights = _repositoryWrapper.FlightsRepository.FindByCondition(l => l.IsNumber == false).ToList();
            }

            return Flights;
        }
        */

        public List<Flights> GetFlights()
        {
            var Flights = new List<Flights>();

            Flights = _repositoryWrapper.FlightsRepository.FindAll().ToList();

            return Flights;
        }

        public void AddFlights(Flights flight)
        {
            _repositoryWrapper.FlightsRepository.Create(flight);
        }
        public void RemoveFlights(Flights flight)
        {
            _repositoryWrapper.FlightsRepository.Delete(flight);
        }
    }
}
