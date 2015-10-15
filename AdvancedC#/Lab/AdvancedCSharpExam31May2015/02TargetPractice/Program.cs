using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] indexOfMatrix = Console.ReadLine().Split();
            string input = Console.ReadLine();
            input.ToCharArray();

            string[] shotLend = Console.ReadLine().Split();

            string[,] matrix = new string[int.Parse(indexOfMatrix[0]), int.Parse(indexOfMatrix[1])];
            int x = 0;
            int counter = 1;
            int rowCount = 0;

            //-- Snake Matrix ||| Start with Down - Right --            
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (rowCount == 0)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = input[x].ToString();
                        counter++;
                        rowCount++;
                        x++;
                        if (x == input.Length)
                        {
                            x = 0;
                        }
                    }
                }
                row--;

                if (rowCount != 0 && row >= 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = input[x].ToString();
                        counter++;
                        x++;
                        if (x == input.Length)
                        {
                            x = 0;
                        }
                    }
                    rowCount = 0;
                }
            }
            // -------------- END ------------

            int rowShot = int.Parse(shotLend[0]);
            int colShot = int.Parse(shotLend[1]);
            int radiusShot = int.Parse(shotLend[2]);

            if (radiusShot > rowShot && radiusShot > colShot )
            {
                if (rowShot >= colShot && colShot != 0)
                {
                    radiusShot = colShot - 1;
                }
                else if (colShot > rowShot && rowShot != 0)
                {
                    radiusShot = rowShot - 1;
                }
                else
                {
                    radiusShot = 0;
                }
            }
                for (int i = rowShot - radiusShot; i <= rowShot + radiusShot; i++)
                {
                    if (rowShot != 0 && i < rowShot + radiusShot)
                    {
                        matrix[i, colShot] = " ";
                    }
                }

                for (int i = colShot - radiusShot; i <= colShot + radiusShot; i++)
                {
                    if (colShot != 0 && i < colShot + radiusShot)
                    {
                        matrix[rowShot, i] = " ";
                    }
                }
                
            if (colShot != 0 && rowShot != 0)
            {
                for (int i = 0; i < radiusShot; i++)
                {
                    matrix[rowShot - i, colShot - 1] = " ";

                    if (rowShot + i < matrix.GetLength(0))
                    {
                        matrix[rowShot + i, colShot + 1] = " ";
                    }
                    
                    matrix[rowShot - i, colShot + 1] = " ";

                    if (rowShot + i < matrix.GetLength(0))
                    {
                        matrix[rowShot + i, colShot - 1] = " ";
                    }
                }
                for (int i = 0; i < radiusShot; i++)
                {
                    matrix[rowShot - 1, colShot - i] = " ";
                    if (colShot + i < matrix.GetLength(1))
                    {
                        matrix[rowShot + 1, colShot + i] = " ";
                    }
                    if (rowShot + i < matrix.GetLength(0))
                    {
                        matrix[rowShot - 1, colShot + i] = " ";
                    }
                    matrix[rowShot + 1, colShot - i] = " ";
                }              
            }

            matrix[rowShot - (radiusShot - 1), colShot - (radiusShot - 1)] = " ";

            if (rowShot + (radiusShot - 1) < matrix.GetLength(0) || colShot + (radiusShot - 1) < matrix.GetLength(1))
            {
                matrix[rowShot + (radiusShot - 1), colShot + (radiusShot - 1)] = " ";
            }
            if (colShot + (radiusShot - 1) < matrix.GetLength(1))
            {
                matrix[rowShot - (radiusShot - 1), colShot + (radiusShot - 1)] = " ";
            }
            if (rowShot + (radiusShot - 1) < matrix.GetLength(0))
            {
                matrix[rowShot + (radiusShot - 1), colShot - (radiusShot - 1)] = " ";
            }


            //-- Characters falling down (remuve space) --
            for (int k = 0; k < radiusShot; k++)
            {
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == " ")
                        {
                            matrix[i, j] = matrix[i - 1, j];
                            matrix[i - 1, j] = " ";
                        }
                    }
                }
            }
            if (colShot == 0 && rowShot == 0)
            {
                matrix[0, 0] = " ";
            }
            //------------- END -------------

            //-- Print on console --
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
