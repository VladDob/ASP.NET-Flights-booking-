using FlightBooking.Models;
using FlightBooking.Repositories.Interfaces;
using FlightBooking.Services.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;

namespace FlightBooking.Services
{
    public class ReservationService : IReservationService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ReservationService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public List<Reservation> GetReservation()
        {
            var Reservation = new List<Reservation>();

            Reservation = _repositoryWrapper.ReservationRepository.FindAll().ToList();

            return Reservation;
        }
    }
}
