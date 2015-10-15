using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SequencesEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.Write(array[0] + " ");

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i-1])
                {
                    Console.WriteLine();
                }
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
