using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../OddLines.txt"))
            {
                using (var writer = new StreamWriter("../../reversed.txt"))
                {
                    int x = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        x++;
                        writer.Write("{0} {1}", x, line);
                        
                        writer.WriteLine();
                        line = reader.ReadLine();
                    }
                }
            }

        }
    }
}
