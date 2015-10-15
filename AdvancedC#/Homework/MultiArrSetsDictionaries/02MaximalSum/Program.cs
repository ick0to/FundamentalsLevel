using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MaximalSum
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

            int[,] matrix = new int[numbers[0], numbers[1]];

            int sum = int.MinValue;
            int result = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbersInMatrix = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbersInMatrix[j];
                }
            }
            int[,] spider = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > result)
                    {
                        result = sum;
                        spider[0, 0] = matrix[i, j];
                        spider[0, 1] = matrix[i, j + 1];
                        spider[0, 2] = matrix[i, j + 2];
                        
                        spider[1, 0] = matrix[i + 1, j];
                        spider[1, 1] = matrix[i + 1, j + 1];
                        spider[1, 2] = matrix[i + 1, j + 2];
                        
                        spider[2, 0] = matrix[i + 2, j];
                        spider[2, 1] = matrix[i + 2, j + 1];
                        spider[2, 2] = matrix[i + 2, j + 2];
                        
                    }
                }
            }
            Console.WriteLine("Sum = {0}",result);
            for (int i = 0; i < spider.GetLength(0); i++)
            {
                for (int j = 0; j < spider.GetLength(1); j++)
                {
                    Console.Write(spider[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
