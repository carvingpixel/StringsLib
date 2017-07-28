﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StringsLib;

namespace StringsWeb.Models
{
    public class Quotes : Analysis
    {
        // Adding Author as SubClass to Inherit SuperClass
        private string _author;


        public string GetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string a)
        {
            _author = a;
        }


    }
}