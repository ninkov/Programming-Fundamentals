using System;

namespace TriangleOfNumbers
{
    class TriangleOfNumbers
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNum; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
