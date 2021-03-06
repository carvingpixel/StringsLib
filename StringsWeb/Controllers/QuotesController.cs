﻿using System;
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



        
        // GET: CHECK() - calling string library to disemenate the string passed from form
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



        
        //DIRECT()
        public ActionResult Direct(string passMe)
        {
            //showing direct access to class library and passing to view via viewbag, model class not access which held inheritance in last example

            if (!String.IsNullOrWhiteSpace(passMe))
            {
                //this shows direct access to the library instantiation @using stringsLib
                var DirectCheck = new Analysis();


                //why bother with setting the string and then making a new variable to pass?
                // security might be a good reason or we need to get it again. but otherwise just kill it
                DirectCheck.SetUserString(passMe);
                var SetString = DirectCheck.GetUserString();


                ViewBag.myC = DirectCheck.CountTotal(SetString);
                ViewBag.myWU = DirectCheck.WordsUnique(SetString);
                ViewBag.myWCU = DirectCheck.CountUnique(SetString);

                // The following works because they are public functions 
                // the string is private so we can set it via the getter setters
                // but the functions themselves are public too so there is no reason to use the string at all
                // and it can be bypassed which may not be what we want. 
                // so do you skip the string in teh properties and make them public
                // or make them private and force inhouse string access
                ViewBag.myC2 = DirectCheck.CountTotal(passMe);
                ViewBag.myWU2 = DirectCheck.WordsUnique(passMe);
                ViewBag.myWCU2 = DirectCheck.CountUnique(passMe);
            }

            return View();
        }


        public ViewResult MVCForm()
        {
            return View();
        }



        // REVIEW()
        public ActionResult Review()
        {
            return View();
        }


    }
}