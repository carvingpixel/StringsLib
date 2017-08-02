using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StringsWeb.Controllers
{
    public class UserResponseController : Controller
    {
        // GET: UserResponse
        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning!" : "Good Afternoon!";
            return View();
        }


        public ViewResult MVCForm()
        {
            return View();
        }


    }
}