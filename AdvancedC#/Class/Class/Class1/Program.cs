using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "iordan93@gmail.com";
            string result = input.Replace("@", "*");
            Console.WriteLine(result);
        }
    }
}
