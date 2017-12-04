namespace FactorialTrailingZeroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int count = 0;
            var res = CalcFactorial(input);
            var output = res;
            while (res % 10 == 0)
            {
                res /= 10;
                count++;
            }
            Console.WriteLine(count);
        }
        public static BigInteger CalcFactorial(BigInteger n)
        {
            BigInteger factorial = 1;
            do
            {
                factorial = factorial * n;
                n--;
            } while (n > 1);
            return factorial;

        }
    }
}
