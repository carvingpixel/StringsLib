using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StringsWeb.Models;
using StringsWeb.ViewModels;
using StringsLib;

namespace StringsWeb.Controllers
{
    public class QuotesController : Controller
    {
        // GET: Quotes(index)
        public ActionResult Index()
        {
            return View();
        }




        // GET: Movies/Check - calling string library to disemenate the string passed from form
        public ActionResult Check(string passMe)
        {
            var myQuote = new Quotes();

            //  getmovies 
            Dictionary<string, int> myWordCounts = new Dictionary<string, int>();


            if (String.IsNullOrWhiteSpace(passMe))
            {
                ViewBag.MyDictionary = myWordCounts;
            }
            else
            {
                myQuote.SetAuthor("Douglas Adams");
                myQuote.SetUserString(passMe);

                // If you want to use ViewBag, we can //
                ViewBag.myC = myQuote.CountTotal(passMe);
                ViewBag.myWU = myQuote.WordsUnique(passMe);
            }

            // passobject through viewmodel
            var viewModel = new CheckQuoteViewModel
            {
                Quote = myQuote,
            };

            // now instead of passing movie, we pass the viewModel 
            return View(viewModel);
        }



        public ActionResult Review()
        {
            return View();
        }


    }
}