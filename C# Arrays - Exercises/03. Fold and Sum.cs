using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //List<int> initial = Console.ReadLine()
            //    .Split(' ').Select(int.Parse).ToList();

            int k = nums.Length / 4;

            List<int> leftPart = nums.Take(k).Reverse().ToList();
            List<int> rightPart = nums.Reverse().Take(k).ToList();

            //Console.WriteLine(string.Join(" ",rightPart));
            int[] downArr = nums.Skip(k).Take(2 * k).ToArray();

            int[] upperPart = leftPart.Concat(rightPart).ToArray();
            
            for (int i = 0; i < downArr.Length; i++)
            {
                downArr[i] += upperPart[i];
            }
            Console.WriteLine(string.Join(" ", downArr));

        }
    }
}
