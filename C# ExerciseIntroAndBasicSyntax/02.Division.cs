using System;

namespace Division
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            int num = 0;

            if (input % 10 == 0)
            {
                num += 10;
                Console.WriteLine($"The number is divisible by {num}");

            }
            else if (input %7 == 0)
            {
                num += 7;
                Console.WriteLine($"The number is divisible by {num}");

            }
            else if (input % 6 == 0)
            {
                num += 6;
                Console.WriteLine($"The number is divisible by {num}");

            }
            else if (input % 3 == 0)
            {
                num += 3;
                Console.WriteLine($"The number is divisible by {num}");

            }
            else if (input % 2 == 0)
            {
                num += 2;
                Console.WriteLine($"The number is divisible by {num}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}

