using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
	class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            List<int> inputNums = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToList();

            int bestCount = 0;
            int bestNum = 0;

            foreach (var num1 in inputNums)
            {
                int count = 0;
                foreach (var num2 in inputNums)
                {
                    if (num1==num2)
                    {
                        count++;
                    }
                }
                if (count>bestCount)
                {
                    bestCount = count;
                    bestNum = num1;
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestNum+" ");
            }

        }
    }
}
