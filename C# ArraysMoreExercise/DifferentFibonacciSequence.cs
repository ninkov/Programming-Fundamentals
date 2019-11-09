using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            //Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            long result = Fib(n);
            //Console.WriteLine("fib({0}) = {1}", n, result);

            Console.WriteLine(result);
        }
        static long Fib(int n)
        {
            long totalFiboNumber = 1;
            long firstFiboNumber = 1;
            long secondFiboNumber = 1;
            for (int i = 2; i < n; i++)
            {
                totalFiboNumber = firstFiboNumber + secondFiboNumber;
                secondFiboNumber = firstFiboNumber;
                firstFiboNumber = totalFiboNumber;
            }
            return totalFiboNumber;
        }
    }
}

