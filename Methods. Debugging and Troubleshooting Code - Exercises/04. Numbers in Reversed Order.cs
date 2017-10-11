using System;
using System.Linq;

namespace NumbersinReversedOrder
{
    class NumbersinReversedOrder
    {
        static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());
            Console.WriteLine(NumberInReverse(input));
        }

        static string NumberInReverse(decimal n)
        {

            string result = string.Join("", n.ToString().Reverse());
            return result;
        }
    }
}
