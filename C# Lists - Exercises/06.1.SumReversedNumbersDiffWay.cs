using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbersDiff
{
    class SumReversedNumbersDiff
    {
        static void Main()
        {

            List<long> nums = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            long sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
				long reversed = 0;
                while (nums[i]>0)
                {
                    long takeLastDigit = nums[i] % 10;
                    reversed = reversed * 10 + takeLastDigit;
                    nums[i] = nums[i] / 10;
                }
				sum += reversed;
               // Console.Write(reversed + " ");
            }
            Console.WriteLine();
            Console.Write(sum + " ");

        }
    }
}
