using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../OddLines.txt");
            var oll = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    oll.Add(line);
                    line = reader.ReadLine();
                }
            }
            for (int i = 0; i < oll.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(oll[i]);
                }
            }
        }
    }
}
