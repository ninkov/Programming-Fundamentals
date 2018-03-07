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

            var currentNum = numbers[0];
            int count = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
              if (currentNum==numbers[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{currentNum} -> {count}");
                    currentNum = numbers[i];
                    count = 1;
                }

            }
			Console.WriteLine($"{currentNum} -> {count}");
        }
    }
}
