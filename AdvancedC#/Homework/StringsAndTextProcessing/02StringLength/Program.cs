using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] array = new char[20];

            for (int i = 0; i < array.Length; i++)
            {
                if (input.Length < array.Length)
                {
                    input = input + "*";
                }
                array[i] = input[i];
            }

            foreach (var item in array)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
