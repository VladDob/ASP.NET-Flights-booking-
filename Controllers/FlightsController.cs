using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightBooking.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using FlightBooking.Models;
using Microsoft.AspNetCore.Http;

namespace FlightBooking.Controllers
{
    public class FlightsController : Controller
    {
        private IFlightsService _FlightsService;

        public FlightsController(IFlightsService FlightsService)
        {
            _FlightsService = FlightsService;
        }

        public IActionResult Flights()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FindFlights()
        {
            var Flights = _FlightsService.GetFlights();

            return Json(Flights);
        }

        [HttpPost]
        public async Task<IActionResult> AddFlight(Flights newFlight)
        {

            Flights flight = new Flights();


            if (!ModelState.IsValid)
            {
                return BadRequest("Enter required fields");
            }

            //flight.Number = 2;
            flight.Departure = newFlight.Departure;
            flight.Arrival = newFlight.Arrival;
            flight.Capacity = newFlight.Capacity; // Int32.Parse(capacity);
            flight.Departure_time = newFlight.Departure_time;
            flight.Arrival_time = newFlight.Arrival_time;
            flight.Plane_type = newFlight.Plane_type;
            flight.Departure_date = "0";
            flight.Arrival_date = "0";

            //Console.Write(flight);

            //try catch??
            try
            {
                _FlightsService.AddFlights(flight);
            }
            catch (Microsoft.AspNetCore.Connections.ConnectionResetException e)
            {
                _FlightsService.AddFlights(flight);
            }
            return this.Ok("Form received");
        }


        [HttpPost]
        public IActionResult RemoveFlights(Flights flight) //object number)
        {

            //Flights flight = new Flights();
            //flight = ApplicationDbContext.Flights.Find(number);

             _FlightsService.RemoveFlights(flight);

            return this.Ok("deleted");
        }
    }
}
 