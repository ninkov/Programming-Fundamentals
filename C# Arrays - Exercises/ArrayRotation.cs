using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Test
    {
        static void Main()
        {

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberToRotate = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberToRotate; i++)
            {
                int first = numbers[0];
                for (int j = 0; j < numbers.Length - 1 % 10; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = first;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

