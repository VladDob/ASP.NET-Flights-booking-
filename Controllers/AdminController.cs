using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using FlightBooking.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;



namespace FlightBooking.Controllers
{
    public class AdminController : Controller
    {
        
        private IReservationService _ReservationService;

        public AdminController(IReservationService ReservationService)
        {
            _ReservationService = ReservationService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminPage()
        {
            return View();
        } 

        [HttpPost]
        public IActionResult FindReservation()
        {
            var Reservation = _ReservationService.GetReservation();

            return Json(Reservation);
        }
    }
}