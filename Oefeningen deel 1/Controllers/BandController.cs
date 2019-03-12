using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;


namespace Oefeningen_deel_1.Controllers
{
    public class BandController : Controller
    {

        public BandController()
        {
            


        }

        public ContentResult Index()
        {
            return Content("Welkom bij uw Band app. Hier komt u alles te weten over de bands en hun leden");
        }

        public ViewResult Lijst(int? id)
        {
            List<string> bandInfo = new List<string>();

            foreach (Band band in Band.GetAll())
            {
                string naam = band?.Naam ?? "unititled";
                int? jaartal = band?.Jaar ?? 0000;
                bandInfo.Add($"naam: {naam}, Jaar: {jaartal}");
            }
            ViewBag.Lijst = bandInfo;
            return View();
        }
    }
}