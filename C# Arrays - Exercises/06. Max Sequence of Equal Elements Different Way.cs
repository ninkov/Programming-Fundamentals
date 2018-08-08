using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
	class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestSequence = 1;
            int currentSequence = 1;
            int bestNum = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]== numbers[i+1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestNum = numbers[i];
                }
               
            }
            for (int i = 0; i < bestSequence ; i++)
            {
                Console.Write(bestNum);
                Console.Write(" ");
            }
        }
    }
}
