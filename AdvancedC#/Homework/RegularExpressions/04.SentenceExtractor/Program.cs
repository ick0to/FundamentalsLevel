using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.SentenceExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            Regex rgx = new Regex(@"(\w[^.!?]*)?(?i:\b" + word + @"\b)[^.!?]*[.!?]");
            MatchCollection matches = rgx.Matches(text);
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
