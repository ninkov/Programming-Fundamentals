using System;

namespace ExchangeVariableValue
{
    class ExchangeVariableValue
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            int temporaryValue = a;
            a = b;
            b = temporaryValue;
            Console.WriteLine($"Before:");
            Console.WriteLine($"a = {b}");
            Console.WriteLine($"b = {a}");

            Console.WriteLine($"After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

        }
    }
}
