using FlightBooking.Models;
using FlightBooking.Repositories.Interfaces;
using FlightBooking.Services.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;

namespace FlightBooking.Services
{
    public class PaymentService : IPaymentService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public PaymentService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public List<Payment> GetPayment()
        {
            var Payment = new List<Payment>();

            Payment = _repositoryWrapper.PaymentRepository.FindAll().ToList();

            return Payment;
        }
    }
}
