
namespace RoundingNumbersAwayfromZero
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RoundingNumbersAwayfromZero
    {
        public static void Main()
        {

            var input = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {

                Console.WriteLine($"{input[i]}" + " => " + (Math.Round(input[i], 0, MidpointRounding.AwayFromZero)));
            }
        }
    }
}
