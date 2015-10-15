using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02TheSieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ushort.Parse(Console.ReadLine());

            HashSet<int> noPrime = new HashSet<int> { };

            for (int x = 2; x < n; x++)
            {
                for (int y = x * 2; y < n; y = y + x)
                {
                    if (!noPrime.Contains(y))
                    {
                        noPrime.Add(y);
                    }
                }
            }
            Console.Write("2");

            for (int z = 3; z <= n; z++)
            {
                if (z != n)
                {
                    if (!noPrime.Contains(z))
                    {
                        Console.Write(", " + z);
                    }
                }
                
            }
            Console.WriteLine();
        }
    }
}
