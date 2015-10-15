using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03ShmoogleCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] result = null;


            List<string> doubles = new List<string> { };
            List<string> ints = new List<string> { };


            while (input != "//END_OF_CODE")
            {

                result = input.Split();
                for (int i = 0; i < result.Length; i++)
                {
                    if (Regex.Match(result[i], @"\w+").ToString() == "double" && result[i] != "(double)" && i + 1 < result.Length)
                    {
                        doubles.Add(Regex.Match(result[i + 1], @"\w+").ToString());
                    }
                    if (Regex.Match(result[i], @"\w+").ToString() == "int" && result[i] != "(int)" && result[i] != "(int" && i + 1 < result.Length)
                    {
                        ints.Add(Regex.Match(result[i + 1], @"\w+").ToString());
                    }
                }
                input = Console.ReadLine();
            }

            doubles.Sort();
            ints.Sort();

            if (doubles.Count == 0)
            {
                Console.WriteLine("Doubles: None");
            }
            else
            {
                Console.WriteLine("Doubles: {0}",string.Join(", ", doubles));

            }

            if (ints.Count == 0)
            {
                Console.WriteLine("Ints: None");
            }
            else
            {
                Console.WriteLine("Ints: {0}", string.Join(", ", ints));

            }

        }
    }
}
