
namespace DrawaFilledSquare
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class DrawaFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            for (int i = 1; i < n-1; i++)
            {
                PrintMidRow(n);
            }
            PrintHeaderRow(n);

        }
        static void PrintMidRow(int n)
        {
            Console.Write("-");

            for (int i = 1; i < n; i++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine("-");
        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
