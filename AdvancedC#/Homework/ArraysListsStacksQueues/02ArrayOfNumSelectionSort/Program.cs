using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02ArrayOfNumSelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();

            int tmp; 
            int minIndex;

            for (int i = 0; i < array.Length - 1; i++)
            {
                minIndex = i;

                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[minIndex])
                    {
                        minIndex = k;
                    }
                }

                tmp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = tmp;
            }


            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
