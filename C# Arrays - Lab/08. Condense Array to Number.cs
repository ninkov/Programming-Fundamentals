
namespace CondenseArraytoNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class CondenseArraytoNumber
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var count = nums.Length;

            while (count > 1)
            {


                int[] condensed = new int[nums.Length - 1];

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                count--;
                nums = condensed;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
