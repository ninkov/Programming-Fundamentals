
namespace ReverseArrayofStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class ReverseArrayofStrings
    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split();
            var reverse = new string[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                reverse[i] = inputArray[inputArray.Length - i - 1];
            }
            Console.WriteLine(string.Join(" ",reverse));
            
        }
    }
}
