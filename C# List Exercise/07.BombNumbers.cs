using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
	class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            int[] command = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            int bombNum = command[0];
            int range = command[1];
            int bombIndex = nums.IndexOf(bombNum);


            while (bombIndex != -1)
            {
                int leftIndex = bombIndex - range;
                int rightIndex = bombIndex + range;

                if (leftIndex < 0 )
                {
                    leftIndex = 0;
                }
                if (rightIndex > nums.Count-1)
                {
                    rightIndex = nums.Count - 1;
                }

                int count = (rightIndex - leftIndex + 1);
                nums.RemoveRange(leftIndex, count);

                bombIndex = nums.IndexOf(bombNum);
            }
            int sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
