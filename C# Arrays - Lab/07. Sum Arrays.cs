
namespace SumArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SumArrays
    {
        public static void Main()
        {
            double[] firstArray = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double[] secondArray = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            var result = new double[Math.Max(firstArray.Length, secondArray.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                var sum = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];

            Console.Write(sum+" ");
            }

        }
    }
}
