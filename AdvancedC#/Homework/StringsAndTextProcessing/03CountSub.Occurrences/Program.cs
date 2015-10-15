using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CountSub.Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            string searchWord = Console.ReadLine();
            searchWord = searchWord.ToLower();
            int x = 0;
            int result = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == searchWord[0])
                {
                    x++;
                    for (int j = 0; j < searchWord.Length; j++)
                    {
                        if (input[i+j] != searchWord[j])
                        {
                            x = 0;
                        }
                    }
                    if (x != 0)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
            
        }
    }
}
