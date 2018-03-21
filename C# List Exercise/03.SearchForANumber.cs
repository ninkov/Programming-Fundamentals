using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class SearchForANumber
    {
        static void Main()


        {            List<int> inputNumbers = Console.ReadLine()
                                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                   .ToList();

            int[] rools = Console.ReadLine()
                                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                   .ToArray();
            List<int> newVision = new List<int>();

            int elementToTake = rools[0];

            for (int i = 0; i < elementToTake; i++)
            {
                newVision.Add(inputNumbers[i]);
            }
			int elementToDelete = rools[1];

            for (int i = 0; i < elementToDelete; i++)
            {
                newVision.RemoveAt(0);
            }
            int searchedNumber = rools[2];
            if (newVision.Contains(searchedNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
          //  Console.WriteLine(string.Join(" ",newVision));
        }
    }
}
