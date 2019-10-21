using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using partyInvity.Models;

namespace partyInvity.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }


        //Adding dynamic output
        public ViewResult MyView()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View();
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(GuestResponse guestResponse)
        {
            //Todo: store response from guest
            Repository.AddResponse(guestResponse);
            return View("ThankYou", guestResponse);
        }

        public ViewResult ListResponse()
        {
            return View(Repository.Responses.Where(r => r.willAttend == true));
        }
    }
}
