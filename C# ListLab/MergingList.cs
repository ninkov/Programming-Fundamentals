using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingList
{
    class MergingList
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int maxIndex = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < maxIndex; i++)
            {
                if (i < firstList.Capacity)
                {
                    result.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

