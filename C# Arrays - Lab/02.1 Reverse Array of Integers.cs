namespace ReverseArrayofIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class ReverseArrayofIntegers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] reversedArray = new int[n];

            for (int i =0; i < reversedArray.Length; i++)
            {
                var result = int.Parse(Console.ReadLine());
                reversedArray[reversedArray.Length - i - 1] = result;
            }
            Console.WriteLine(string.Join(" ",reversedArray));
            

        }
    }
}
