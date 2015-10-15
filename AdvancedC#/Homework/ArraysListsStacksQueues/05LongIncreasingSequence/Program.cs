using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LongIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();

            List<int> longest = new List<int> { };
            List<int> result = new List<int> { };
            int x = 0;

            Console.Write(numbers[0] + " ");

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= numbers[i - 1])
                {
                    Console.WriteLine();
                }
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            longest.Add(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i-1])
                {
                    longest.Add(numbers[i]);
                }

                if (longest.Count() > result.Count)
                {
                    for (int k = 0; k < longest.Count; k++)
                    {
                        result.Add(longest[k]);
                    }
                    longest.Clear();


                }
            } 

            Console.Write("Longest: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
