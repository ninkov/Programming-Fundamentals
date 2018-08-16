using System;
using System.Linq;
using System.Collections.Generic;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main()
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();
            inputNumbers.Sort();

            int count = 1;
            int currentNumber=inputNumbers[0];
            for (int i = 1; i < inputNumbers.Count; i++)
            {
                
                if (currentNumber == inputNumbers[i])
                {
                    count++;
                }
                else
                {
                    Console.Write(currentNumber);
                    Console.WriteLine(" -> "+count);
                    currentNumber = inputNumbers[i];
                    count = 1;

                }
            }
            Console.Write(currentNumber);
            Console.WriteLine(" -> "+count);


        }
    }
}
