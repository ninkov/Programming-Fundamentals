using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 1;
            int third = 0;
            //Console.Write("First {0} Fibonacci numbers {1} {2} ", input, first, second);

            for (int i = 3; i <= input; i++)
            {
                third = first + second;
              //  Console.Write("{0} ", third);
                first = second;
                second = third;

            }
            int sum = first + second;
            Console.WriteLine(sum);
        }
    }
}

