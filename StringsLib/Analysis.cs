using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace StringsLib
{
    public class Analysis
    {
        private string _userString;


        // set user string call clearCharacters and ToLower()
        public void SetUserString(string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            s = sb.ToString();
            _userString = s.ToLower();
        }


        //Clear out punctuation
        public string ClearCharacters(string cc)
        {
            var clearString = new string(cc.Where(c => !char.IsPunctuation(c)).ToArray());
            return clearString;
        }


        //get user string
        public string GetUserString()
        {
            return _userString;
        }


        //Count Total
        public int CountTotal(string phrase)
        {
            MatchCollection collection = Regex.Matches(phrase, @"[\S]+");
            return collection.Count;

        }

        //words unique
        public int WordsUnique(string phrase)
        {
            var result = phrase.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(r => r)
                .Select(grp => new
                {
                    Word = grp.Key,
                    Count = grp.Count()
                });

            //get total count of unique words
            var grandTotal = 0;
            foreach (var c in result)
            {
                int current = 1;
                grandTotal += current;
            }
            return grandTotal;
        }


        //count unique 
        public Dictionary<string, int> CountUnique(string phrase)
        {
            var result = phrase.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(r => r)
                .Select(grp => new
                {
                    Word = grp.Key,
                    Count = grp.Count()
                });

            //Sort ienumerable of result Words
            var sortedWords = result.OrderBy(a => a.Word);

            //store sorted unique word and count in dictionary
            var uniqueDict = new Dictionary<string, int>();
            foreach (var item in sortedWords)
            {
                uniqueDict.Add(item.Word, item.Count);
            }
            return uniqueDict;
        }



    }
}
