using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int x = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = x; 
                    x++;
                }
                
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[j,i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            x = 2;
            List<int> matrixRubic = new List<int> { };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                if (x % 2 == 0)
                {                    
                    for (int j = 0; j < n; j++)
                    {
                        matrixRubic.Add(matrix[i,j]);
                    }
                }
                else if (x % 2 != 0)
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        matrixRubic.Add(matrix[i, j]);
                    }
                }
                x++;
            }
            x = 0;
            int[,] matrix2 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix2[i, j] = matrixRubic[x];
                    x++;
                    
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix2[j,i] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
