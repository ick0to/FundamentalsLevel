using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> convert = new List<char> { };
            
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    convert.Add(input[i]);   
                }
            }
            convert.Add(input[input.Length-1]);
            foreach (var item in convert)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
