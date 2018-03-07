using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbres
{
    class CountNumbres
    {
        static void Main()
        {
			//8 2 2 8 2 2 3 7
            List<int> numbers = Console.ReadLine()
                                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            numbers.Sort();

            int[] numsOfCount = new int[1001];

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNum = numbers[i];

                if (currentNum==numbers[i])
                {
                    numsOfCount[currentNum]++;
                }
            }
            for (int i = 0; i < numsOfCount.Length; i++)
            {
                var currentNumber = numsOfCount[i];

                if (currentNumber > 0 )
                {
                    Console.WriteLine($"{i} -> {currentNumber}");
                }
            }
        }
    }
}

