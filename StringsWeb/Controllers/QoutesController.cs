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


        public ActionResult Create(string quoteGiven)
        {

            //        var disemenate = new Analysis();
            var genInfo = new Analysis
            {
                Name = "Hitchhiker's Guide to the Galaxy Part 2",
                UserString = quoteGiven
            };
            
            //Passing quote into view instead
            //var ctResult = genInfo.CountTotal(quoteGiven);
            //var wuResult = genInfo.WordsUnique(quoteGiven);
            // var cuResult = disemenate.CountUnique(quoteGiven);

            return View($"Library", genInfo);

        }



    }
}