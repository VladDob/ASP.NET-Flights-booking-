using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Controllers
{
    public class DestinationsController : Controller
    {
        public IActionResult Destinations()
        {
            return View();
        }
    }
}