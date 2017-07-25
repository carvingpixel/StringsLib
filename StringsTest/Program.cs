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
            // QUICK TESTS VIA CONSOLE FOR LIBRARY TO PARSE STRING/WORD COUNTS
            var checkString = new Analysis();


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
            Dictionary<string, int> myDictionary = checkString.CountUnique(givenQuote);
            foreach (var subItem in myDictionary)
            {
               Console.WriteLine(subItem.Key + " " + subItem.Value);
            }



            // All items complete in Analysis Library
            Console.ReadLine();

        }
    }
}
