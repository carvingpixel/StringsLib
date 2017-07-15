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
            var movie = new Quotes() { Title = "Hitchhicker's Guide to the Galaxy", Author = "Douglas Adams"};

            Analysis testMe = new Analysis() { Name = "Lokin Crook" }; 

            return View(testMe);
        }
    }
}