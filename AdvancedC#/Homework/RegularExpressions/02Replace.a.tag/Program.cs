using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Replace.a.tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = text[i].Replace("<a", "");
                text[i] = text[i].Replace("href=", "[URL href=");
                text[i] = text[i].Replace("</a>", "[/URL]");
                text[i] = text[i].Replace("\"", "");
                text[i] = text[i].Replace("\'", "");
            }

            foreach (var item in text)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
