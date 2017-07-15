using System;
using StringsLib;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup console for checks of each task in analysis library 

            //Create Analysis Object library to access methods to take apart strings
            var checkString = new Analysis();
            Console.WriteLine(checkString.Name); // what is hitchhikers guide to the galaxy by douglas adams
   
            //accept a string from user as input TEST set to lower
            Console.WriteLine("Provide a string quote to check");
            string givenQuote = Console.ReadLine();
            givenQuote.ToLower();

            //Analyze total count of words
            var wordCount = checkString.CountTotal(givenQuote);
            Console.WriteLine("Total Word Count: " + wordCount);

            //Total Count of Unique Words 
            checkString.WordsUnique(givenQuote);

            //Uunique words  
            checkString.CountUnique(givenQuote);

            // All items complete in Analysis Library
            Console.ReadLine();
        }
    }
}
