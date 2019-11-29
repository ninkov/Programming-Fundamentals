using System;
using System.Collections.Generic;
using System.Linq;

namespace NxNMatrix
{
    class NxNMatrix
    {
        static void Main()
        {
            PrintMatrixNxN();
        }
        static void PrintMatrixNxN()
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 0; i < range; i++)
            {
                for (int j = 0; j < range; j++)
                {
                    Console.Write(range+" ");
                }
                Console.WriteLine();
            }
        }
    }
}

