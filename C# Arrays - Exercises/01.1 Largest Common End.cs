
namespace LargestCommonEnd
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class LargestCommonEnd
    {
        static void Main()
        {
            var firstArray = Console.ReadLine()
                .Split();
            var secondArray = Console.ReadLine()
                .Split();
            int path = Math.Min(firstArray.Length, secondArray.Length);

            var fCount = 0;
            var sCount = 0;
            for (int i = 0; i < path; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    fCount++;
                }
            }

            for (int i = 0; i < path; i++)
            {

                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    sCount++;

                }

            }
            if (fCount>sCount)
            {
                Console.WriteLine(fCount);
            }
            else
            {
                Console.WriteLine(sCount);
            }
        }
    }
}
