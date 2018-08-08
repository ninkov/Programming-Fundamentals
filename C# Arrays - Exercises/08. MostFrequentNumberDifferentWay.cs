using System;
using System.Linq;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            //read input
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            //initial values
            int maxNum = 0;
            int maxCount = 0;
            //logic
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i]==numbers[j])
                    {
                        count++;
                    }
                }
                if (maxCount<count)
                {
                    maxCount = count;
                    maxNum = numbers[i];
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
