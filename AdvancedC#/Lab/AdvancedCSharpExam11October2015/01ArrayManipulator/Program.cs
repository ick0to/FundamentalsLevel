using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> list = new List<string> { };
            while (input != "//END_OF_CODE")
            {
                list.Add(input);
                input = Console.ReadLine();
            }

            foreach (var item in list)
            {
                Console.Write(list);
            }
            Console.WriteLine();
        }
    }
}
