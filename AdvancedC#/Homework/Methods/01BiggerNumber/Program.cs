using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());

            int max = GetMax(firstN, secondN);
            Console.WriteLine(max);

        }

        void GetMax(int firstN, int secondN)
        {
            int result = 0;
            if (firstN > secondN)
            {
                result = firstN;
                 
            }
            else if (firstN < secondN)
            {
                result = secondN;
            }

            
        }
    }
}
