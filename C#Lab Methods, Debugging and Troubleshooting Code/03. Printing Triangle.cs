
namespace PrintingTriangle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class PrintingTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                PrinntLine(1, i);
            }
            PrinntLine(1,n);
            for (int i = n - 1; i >= 0; i--)
            {
                PrinntLine(1, i);
            }
        }

        private static void PrinntLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
