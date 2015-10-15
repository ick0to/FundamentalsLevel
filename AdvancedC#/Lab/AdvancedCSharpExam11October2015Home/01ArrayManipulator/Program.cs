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

            List<string> output = new List<string> ();

            
            
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command.Contains("max") || command.Contains("min"))
                {
                    var outOddEven = OddEvenMinMax(input, command);
                    if (outOddEven == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        output.Add(outOddEven.ToString());
                    }
                    
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }

        }
        static int OddEvenMinMax(string input, string command)
        {
            var splitIn = input.Split().Select(int.Parse).ToList();


            var splitCom = command.Split();
            var odd = new List<int>();
            var even = new List<int>();
            int output = -1;

            for (int i = 0; i < splitIn.Count; i++)
            {
                if (splitIn[i] % 2 == 0)
                {
                    even.Add(splitIn[i]);
                }
                else if (splitIn[i] % 2 != 0)
                {
                    odd.Add(splitIn[i]);
                }
            }
            if (splitCom[1] == "even" && even.Count != 0)
            {
                if (splitCom[0] == "max")
                {                    
                    output = splitIn.FindIndex(x => x == even.Max());
                }
                else if (splitCom[0] == "min")
                {
                    output = splitIn.FindIndex(x => x == even.Min());
                    
                }

            }
            else if (splitCom[1] == "odd" && odd.Count != 0)
            {
                if (splitCom[0] == "max")
                {
                    output = splitIn.FindIndex(x => x == odd.Max());
                }
                else if (splitCom[0] == "min")
                {
                    output = splitIn.FindIndex(x => x == odd.Min());                    
                }
                
            }
            
            return output;
        }
    }
}
