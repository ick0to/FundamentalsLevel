using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public static class Randam
    {
        public static int[] RandamNumbers(this int[] numbers[])
        {
            Randam n = new Randam();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = n;
            }
        }
    }
}
