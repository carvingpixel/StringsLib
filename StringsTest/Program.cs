using System;
using StringsLib;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

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
            string lowerQuote = givenQuote.ToLower();


            //Analyze total count of words
            Console.WriteLine("Total Word Count: " + checkString.CountTotal(lowerQuote));


            //Total Count of Unique Words 
            Console.WriteLine("Unique Words:" + checkString.WordsUnique(lowerQuote));


            //Count Each Unique Word and display 
            Dictionary<string, int> myDictionary = checkString.CountUnique(lowerQuote);
            foreach (var subItem in myDictionary)
            {
                Console.WriteLine(subItem.Key + " " + subItem.Value);
            }

            Console.Write("Type R to Reload Check: ");
            // All items complete in Analysis Library

            var reload = Console.ReadKey();
            if (reload.Key == ConsoleKey.R)
            {
                var SimpleCheck = Assembly.GetExecutingAssembly().Location;
                System.Diagnostics.Process.Start(SimpleCheck);
            }

        }
    }
}
