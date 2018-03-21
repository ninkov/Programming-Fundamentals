using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            
            int currentStart = 0;
            int currentLength = 1;
            int bestStrart = 0;
            int bestLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
				
                if (numbers[i] == numbers[i-1])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStrart = currentStart;
                    }

                }
                else
                {
                    currentLength = 1;
                    currentStart = i;
                }

            }

            for (int i = bestStrart; i < bestStrart+bestLength; i++)
            {


                Console.Write(numbers[i]+" ");
            }

        }
    }
}
