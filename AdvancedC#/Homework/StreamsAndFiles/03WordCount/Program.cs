using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var words = new StreamReader("../../words.txt"))
            {
                using (var text = new StreamReader("../../text.txt"))
                {
                    using (var result = new StreamWriter("../../result.txt"))
                    {
                        string line = text.ReadLine();
                        while (line != null)
                        {

                            result.Write(line);
                            
                            result.WriteLine();
                            line = words.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
