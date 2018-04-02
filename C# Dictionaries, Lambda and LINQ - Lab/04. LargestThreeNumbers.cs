using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestThreeNumbers
{
    class LargestThreeNumbers
    {
        static void Main()
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result =  inputNumbers.OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
