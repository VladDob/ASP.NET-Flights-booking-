﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Controllers
{
    public class InfoPageController : Controller
    {
        public IActionResult InfoPage()
        {
            return View();
        }
    }
}