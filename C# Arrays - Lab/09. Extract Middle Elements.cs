
namespace ExtractMiddleElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class ExtractMiddleElements
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var n = numbers.Length;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (n == 1)
                {
                    Console.WriteLine(numbers[0]);
                    break;
                }
                else if (n % 2 == 0)
                {
                    Console.WriteLine("{ " + $"{numbers[numbers.Length / 2 - 1]}" + "," + $"{numbers[numbers.Length / 2]}" + " }");
                    break;
                }
                else if (n % 2 != 0)
                {
                    Console.WriteLine("{ " + $"{numbers[numbers.Length / 2 - 1]}" + "," + $"{numbers[numbers.Length / 2]}" + "," + $"{numbers[numbers.Length / 2 + 1]}" + " }");
                    break;
                }
            }
        }
    }
}
