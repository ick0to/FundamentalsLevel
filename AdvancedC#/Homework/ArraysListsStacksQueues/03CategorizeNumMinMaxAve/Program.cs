using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CategorizeNumMinMaxAve
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => double.Parse(item))
                .ToArray();

            List<double> floatNum = new List<double> { };
            List<int> roundNum = new List<int> { };

            for (int i = 0; i < numbers.Length; i++)
            {
                double cheker = numbers[i];
                if (cheker == (int)cheker)
                {
                    roundNum.Add((int)numbers[i]);
                }
                if (cheker != (int)cheker)
                {
                    floatNum.Add(numbers[i]);
                }
            }

            double floatMin = floatNum.Min();
            double floatMax = floatNum.Max();
            double floatSum = floatNum.Sum();
            double floatAvg = floatNum.Average();

            int roundMin = roundNum.Min();
            int roundMax = roundNum.Max();
            int roundSum = roundNum.Sum();
            double roundAvg = roundNum.Average();
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:00}",string.Join(", ",floatNum), floatMin,floatMax,floatSum,floatAvg);
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:00}", string.Join(", ", roundNum), roundMin, roundMax, roundSum, roundAvg);

        }
    }
}
