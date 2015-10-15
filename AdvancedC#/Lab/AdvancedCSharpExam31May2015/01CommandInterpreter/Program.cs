using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().Split().ToArray();
            string commands = null;
            bool j = true;
            int times = 0;

            var result = new string[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                result[i] = inputString[i];
            }

            try
            {
            while (commands != "end")
            {
                commands = Console.ReadLine();
                times++;
                if (commands != "end")
                {

                    var numberOfIndex = (from t in commands
                                         where char.IsDigit(t)
                                         select t).ToArray();
                    int x = numberOfIndex[0] - 48;
                    if (commands.Contains("reverse"))
                    {
                        for (int i = (numberOfIndex[0] - 48) + (numberOfIndex[1] - 48) - 1; i >= numberOfIndex[0] - 48; i--)
                        {
                            
                                result[x] = inputString[i];
                                x++;
                           
                        }

                    }
                    else if (commands.Contains("sort"))
                    {
                        result = SortMethod(result, numberOfIndex[0], numberOfIndex[1]);
                        
                    }
                    else if (commands.Contains("rollLeft"))
                    {
                        result = RollLeft(result, numberOfIndex[0]);
                    }
                    else if (commands.Contains("rollRight"))
                    {
                        result = RollRight(result, numberOfIndex[0]);
                    }
                }
                if (commands.Contains(@"!reverse") && commands.Contains(@"!sort") && commands.Contains(@"!rollLeft") && commands.Contains(@"!rollRight"))
                {
                    Console.WriteLine("Invalid input parameters.");
                    j = false;
                }
            }
            }
            catch (Exception)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine("Invalid input parameters.");   
                }
            }
            if (j == true)
            {

                Console.WriteLine("[{0}]", string.Join(", ", result));
            }
                      
            
        }
        static string[] SortMethod(string[] array,int index,int count)
        {
            List<string> sortedList = new List<string> { };
            

            for (int i = index - 48; i < (index - 48) + (count - 48); i++)
            {
                sortedList.Add(array[i]);
            }
            sortedList.Sort();
            int x = 0;
            for (int i = index - 48; i < (index - 48) + (count - 48); i++)
            {
                array[i] = sortedList[x];
                x++;
            }
             return array;
        }
        static string[] RollLeft(string[] array, int count)
        {
            count = count - 48;
            List<string> firstToLast = new List<string> { };
            for (int i = 0; i < count; i++)
            {
                firstToLast.Add(array[i]);
            }

            for (int i = 0; i < array.Length - count; i++)
            {
                array[i] = array[i + count];
            }
            int x = firstToLast.Count - 1;
            for (int i = array.Length - 1; i > array.Length - count - 1; i--)
            {
                array[i] = firstToLast[x];
                x--;
            }

            return array;
        }
        static string[] RollRight(string[] array, int count)
        {
            count = count - 48;
            List<string> firstToLast = new List<string> { };
            for (int i = array.Length - 1; i >= array.Length - count; i--)
            {
                firstToLast.Add(array[i]);
            }

            for (int i = array.Length - 1; i >= count; i--)
            {
                array[i] = array[i - count];
            }
            int x = firstToLast.Count - 1;
            for (int i = 0; i < count; i++)
            {
                array[i] = firstToLast[x];
                x--;
            }

            return array;
        }
    }
}
