using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04СръбскоUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> venue = new List<string> { };
            List<string> singer = new List<string> { };
            List<int> ticketsPrice = new List<int> { };
            List<int> ticketsCount = new List<int> { };

            while (input != "End")
            {
                if (Regex.Match(input, @" \@\D+\D+", RegexOptions.Singleline | RegexOptions.IgnoreCase).Success)
                {
                    venue.Add(Regex.Match(input, @" \@\D+\D+").ToString().Replace(" @", ""));
                    singer.Add(Regex.Match(input, @"\w+.\w+ \@").ToString().Replace("@",""));
                    string[] numbers = Regex.Split(input, @"\D+");
                    ticketsPrice.Add(int.Parse(numbers[1]));
                    ticketsCount.Add(int.Parse(numbers[2]));
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> money = new Dictionary<string, int>();
            List<string> all = new List<string>();

            for (int k = 0; k < venue.Count; k++)
            {
                if (!all.Contains(venue[k]))
                {
                    all.Add(venue[k].Replace(@"\s+$", ""));
                    for (int i = 0; i < singer.Count; i++)
                    {
                        if (!money.ContainsKey(singer[i]))
                        {
                            money.Add(singer[i], ticketsPrice[i] * ticketsCount[i]);
                        }
                        else if (money.ContainsKey(singer[i]))
                        {
                            string x = singer[i];
                            int z = money[x];
                            money[x] = z + (ticketsCount[i] * ticketsPrice[i]);
                        }
                    }
                }
            }

            var items = from pair in money
                        orderby pair.Value descending
                        select pair;

            Console.WriteLine(all[0]);
            foreach (KeyValuePair<string, int> pair in items)
            {
                Console.WriteLine("#  {0}-> {1}",
                pair.Key,
                pair.Value);
            }
        }
    }
}
