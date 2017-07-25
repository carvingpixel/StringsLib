﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StringsWeb.Models;
using StringsLib;
using StringsWeb.ViewModels;

namespace StringsWeb.Controllers
{
    public class QoutesController : Controller
    {

        // GET: Movies/Check - calling string library to disemenate the string passed from form
        public ActionResult Check(string passMe)
        {
            var myQuote = new Quotes();
            // Using enum getmovies method for fun
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            // if null or white set defaults
            if (String.IsNullOrWhiteSpace(passMe))
            {
                ViewBag.MyDictionary = myDictionary;
                myQuote.UserString = "";
            }
            else
            {
                myQuote.UserString = passMe;
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