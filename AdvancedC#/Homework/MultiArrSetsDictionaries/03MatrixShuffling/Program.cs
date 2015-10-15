using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];
            int x = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }
            
            string input = null;
            string swap = "";
            List<int> swap1 = new List<int> { };
            List<int> swap2 = new List<int> { };
            List<int> swap3 = new List<int> { };
            List<int> swap4 = new List<int> { };


            string replace = "";
            while (input != "END")
            {
                input = Console.ReadLine();
                if (input != "END")
                {
                swap = Regex.Replace(input, @"[^0-9]","");
                swap1.Add(Convert.ToInt32(swap[0].ToString()));
                swap2.Add(Convert.ToInt32(swap[1].ToString()));
                swap3.Add(Convert.ToInt32(swap[2].ToString()));
                swap4.Add(Convert.ToInt32(swap[3].ToString()));

                if (input == "0 0 0 1")
                {
                    x = 1;
                }

                }
            }
            for (int i = 0; i < swap1.Count; i++)
            {
                if (swap1[i] > rows || swap2[i] > cols || swap3[i] > rows || swap4[i] > cols || x == 1)
                {
                    Console.WriteLine("Invalid input!");
                    x = 0;
                }
                else
                {
                replace = matrix[swap1[i], swap2[i]];
                matrix[swap1[i], swap2[i]] = matrix[swap3[i], swap4[i]];
                matrix[swap3[i], swap4[i]] = replace;


                    for (int j = 0; j < rows; j++)
                    {
                        for (int k = 0; k < cols; k++)
                        {
                            Console.Write(matrix[j, k] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            
        }
    }
}
