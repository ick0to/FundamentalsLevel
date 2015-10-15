using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banString = Console
                .ReadLine()
                .Split(new Char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string inputText = Console.ReadLine();
            for (int i = 0; i < banString.Length; i++)
            {
                string star = new string('*',banString[i].Length);
            
                inputText = inputText.Replace(banString[i], star);
                
            }

            Console.WriteLine(inputText);
        }
    }
}
