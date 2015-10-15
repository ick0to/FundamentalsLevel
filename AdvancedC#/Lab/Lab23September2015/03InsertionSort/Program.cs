using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();
            List<int> numbers = new List<int> { };
            for (int i = 0; i < n.Length; i++)
            {
                numbers.Add(n[i]);
            }
            for (int j = 0; j < numbers.Count; j++)
            {
                for (int i = 1; i < numbers.Count; i++)
                {
                    int x = numbers[i-1];
                    if (x > numbers[i])
                    {
                        numbers[i-1] = numbers[i];
                        numbers[i] = x;
                    }
                
                }
                
            }
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
