using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (numbersCount.ContainsKey(num))
                {
                    numbersCount[num]++;
                }
                else
                {
                    numbersCount[num] = 1;
                }
            }

          

            foreach (var kvp in numbersCount)
            {
                double number = kvp.Key;
                int count = kvp.Value;

                Console.WriteLine($"{number} -> {count}");
            }
        }
    }
}
