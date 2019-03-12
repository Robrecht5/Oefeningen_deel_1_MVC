using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Oefeningen_deel_1.Controllers
{
    public class BandController : Controller
    {

        public BandController()
        {

        }

        public string Index()
        {
            return "Welkom bij uw Band app. Hier komt u alles te weten over de bands en hun leden";
        }

        public IActionResult Lijst()
        {
            return View();
        }
    }
}