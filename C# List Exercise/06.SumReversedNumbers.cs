using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main()
        {
            List<string> numbers = Console.ReadLine()
                                       .Split(new[] { ' ' }, StringSplitOptions.None)
                                       .ToList();
            var reversed = new List<decimal>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string number = numbers[i];
                string reversedStr = stringRevesd(number);
                int num = int.Parse(reversedStr);
                reversed.Add(num);
            }
            Console.WriteLine(reversed.Sum());
        }
        public static string stringRevesd(string number)

        {
            char[] array = number.ToCharArray();
            char[] revers = array.Reverse().ToArray();
            string resversedString = string.Join("", revers);

            return resversedString;
        }
    }
}

