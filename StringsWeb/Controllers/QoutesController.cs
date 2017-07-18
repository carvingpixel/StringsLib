using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StringsWeb.Models;
using StringsLib;

namespace StringsWeb.Controllers
{
    public class QoutesController : Controller
    {
        // GET: Qoutes/Library
        public ActionResult Library()
        {
            var genInfo = new Analysis() { Name = "Hitchhiker's Guide to the Galaxy" };

            return View(genInfo);
        }



        public ActionResult Review(string quoteGiven)
        {

            var myAsys = new Quotes()
            {
                TitleQuote = "Calculate the answer to the Ultimate Question of Life",  
                Author = "Douglas Adams",
                Name ="Such Deep Thought, Thank You",
                UserString = quoteGiven
            };

            //Passing quote into view instead
            //var ctResult = genInfo.CountTotal(quoteGiven);
            //var wuResult = genInfo.WordsUnique(quoteGiven);
            // var cuResult = disemenate.CountUnique(quoteGiven);

            ViewBag.Asys = myAsys;  //dont use viewbag - magic method issues MovieMagicM too fragile spreads through code
            return View();

        }



    }
}