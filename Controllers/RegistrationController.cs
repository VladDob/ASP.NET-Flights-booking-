using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using FlightBooking.Models;
using Microsoft.AspNetCore.Identity;

namespace FlightBooking.Controllers
{
    public class RegistrationController : Controller
    {
        /*
        private readonly UserManager<User> UserManager;
        private readonly SignInManager<User> SignInManager;

        public RegistrationController(UserManager<User> userManager,
                                        SignInManager<User> signInManager)
        {
            this.UserManager = userManager;
            this.SignInManager = signInManager;
        }
        */

       // [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        /*    [HttpPost]
            public IActionResult Registration(User model)
            {
                if (ModelState.IsValid)
                {
                    var user = new User
                    {
                        UserName = model.Name,
                        Surname = model.Surname,
                        Email = model.Email
                        //continue here

                    };
                    ModelState.Clear();
                }
                return View(model);
            }
    */
    }
}