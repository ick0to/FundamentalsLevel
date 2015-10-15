using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console
                .ReadLine()
                .Split(new Char[] { '.','?','!',',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> result = new List<string> { };
            for (int i = 0; i < input.Length; i++)
            {
                string x = input[i];
                string y = new string (input[i].Reverse().ToArray());
                
                    if (x == y)
                    {
                        result.Add(input[i] + ", ");
                    }
            }
            result.Sort();
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
