using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main()
        {
            List<double> nums = Console.ReadLine()
                                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(double.Parse)
                                       .ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {

                var currentWord = nums[i];
                if (Math.Sqrt(currentWord) == (int)Math.Sqrt(currentWord))
                {
                    result.Add((int)nums[i]);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
