using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04LinearAndBinarySearch
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
            int search = int.Parse(Console.ReadLine());
            int result = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search && result == -1)
                {
                    result = i;
                }
            }
            
            Console.WriteLine(result);
        }
    }
}
