using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
	class MaxSequenceOfEqualElements
    {
        static void Main()
        {
 
int[] arr = Console.ReadLine()
                           .Split()
                               .Select(int.Parse)
                               .ToArray();

            int startIndex = 0;
            int maxStart = 0;
            int maxLength = 1;
            int currentLength = 1;

            for (int index = 1; index < arr.Length; index++)
            {
                if (arr[index] == arr[index - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = startIndex;
                    }

                }
                else
                {
                    currentLength = 1;
                    startIndex = index;
                }
            }
            for (int i = maxStart; i < maxStart + maxLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
