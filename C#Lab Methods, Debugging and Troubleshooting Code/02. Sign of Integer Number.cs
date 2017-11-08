
namespace SignofIntegerNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SignofIntegerNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSing(n);
        }

        private static void PrintSing(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
                return;
            }
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
                return;
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
                return;
            }

        }
    }
}
