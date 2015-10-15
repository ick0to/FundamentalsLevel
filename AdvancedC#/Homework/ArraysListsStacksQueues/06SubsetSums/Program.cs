using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SubsetSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();
            int sum = 0;
            List<int> stufs = new List<int> { };
            List<int> result = new List<int> { };


            double combined = Math.Pow(2, numbers.Length);

            for (int i = 0; i < combined; i++)
            {
                sum = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    int mask = i & (1 << j);
                    if (mask != 0)
                    {
                        sum = sum + numbers[numbers.Length - 1 - j];
                        stufs.Add(numbers[numbers.Length - 1 - j]);
                    }
                }
                if (sum == n)
                {
                    result.Add(stufs[0]);
                }
                stufs = new List<int> { };
                if (result.Count == 0)
                {
                    Console.WriteLine("No matching subsets.");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item);
                    }
                }
            }


        }
    }
}
