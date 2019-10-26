using System;
using System.Linq;

namespace EqualSum
{
    class EqualSum
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            int rigthSum = 0;
            int leftSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                rigthSum += numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                rigthSum -= numbers[i];
                if (leftSum==rigthSum)
                {
                    Console.WriteLine(i);
                    break;
                }
                leftSum += numbers[i];
            }
            if (leftSum!=rigthSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}

