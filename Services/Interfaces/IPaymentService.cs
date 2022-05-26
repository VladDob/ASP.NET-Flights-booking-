using FlightBooking.Models;
using System.Collections.Generic;

namespace FlightBooking.Services.Interfaces
{
    public interface IPaymentService
    {
        List<Payment> GetPayment();
    }
}
