using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ConvertToUnicode(input));
        }

        
        private static string ConvertToUnicode(string input)
        {
            StringBuilder utf = new StringBuilder(input.Length * 6);

            foreach (char c in input)
                utf.AppendFormat("\\u{0:X4}", (int)c);

            return utf.ToString();
        }
    }
}
