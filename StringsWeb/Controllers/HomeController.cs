using System;
using StringsLib;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StringsWeb.Models;

namespace StringsWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Test = "Test viewbag";
            return View();
        }


        public ActionResult Aspwp()
        {

            ViewBag.Heading = "ASP Web Pages";
            ViewBag.Title = ViewBag.Heading;
            ViewBag.ArrayText = ArrayOut();

            var rockit = new Aspwp();
            rockit.Odd = "Ricky Rocket Model Name";
            ViewBag.modCheck = rockit.Odd;

            return View(rockit);
        }



        readonly string[] BushesofLove = new string[3] { "Chicken Head", "With", "Duck Feet" };


        public string ArrayOut()
        {
            var arrayText = "";
            foreach (var bol in BushesofLove)
            {
                // Response.Write(bol + " ");
                var temp = bol + " ";
                arrayText = arrayText + temp;
            }
            return arrayText;
        }


    }
}