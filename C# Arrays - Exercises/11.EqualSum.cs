using System;
using System.Linq;

namespace EqualSums
{
	class EqualSums
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            int totalSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                totalSum += arr[i];
            }
            int leftSum = 0;
            int rightSum = totalSum;
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                rightSum -= currentNumber;
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    found = true;
                    break;
                }
                leftSum += currentNumber;
            }
            if (found==false)
            {
                Console.WriteLine("no");
            }

        }
    }
}
