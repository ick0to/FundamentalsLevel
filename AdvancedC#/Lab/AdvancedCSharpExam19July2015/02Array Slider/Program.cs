using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Array_Slider
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string line = Console.ReadLine();

            int currentIndex = 0;

            // - 3
            // 0 0 2 0 0
            while (line != "stop")
            {
                var lineArgs = line.Split(new char[] { },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

                int offset = int.Parse(lineArgs[0]) % arr.Length;
                string operation = lineArgs[1];
                ulong operand = ulong.Parse(lineArgs[2]);

                if (offset < 0)
                {
                    currentIndex = (currentIndex + offset + arr.Length) % arr.Length;
                }
                else
                {
                    currentIndex = (currentIndex + offset) % arr.Length;
                }
                ProcessCommand(arr, currentIndex, operation, operand);

                line = Console.ReadLine();
            }

        }

        private static void ProcessCommand(int[] arr, int currentIndex, string operation, int operand)
        {
            switch (operation)
            {
                case "&": break;
                    arr[currentIndex] &= operand;
                case "|": break;

                case "^": break;

                case "+": break;

                case "-": break;

                case "*": break;

                case "/": break;

        
            }
        }
    }
}
