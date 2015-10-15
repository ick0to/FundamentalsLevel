using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RadioactiveMVamBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] indexOfMatrix = Console.ReadLine().Split();
            string[,] matrix = new string[int.Parse(indexOfMatrix[0]), int.Parse(indexOfMatrix[1])];
            string input = Console.ReadLine();
            
            string result = null;

            while (true)
            {
                result = result + input;

            }
            result.ToCharArray();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {


                    
                }
            }







            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
