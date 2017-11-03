namespace LastKNumbersSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LastKNumbersSums
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            sequence[0] = 1;


            for (int i = 1; i < sequence.Length; i++)
            {

                long start = Math.Max(0, i - k);
                long end = i - 1;
                long sum = 0;
                for (long j = start; j <= end; j++)
                {
                    sum += sequence[j];
                }
                sequence[i] = sum;
            }
            Console.Write(string.Join(" ", sequence));

        }
    }
}
