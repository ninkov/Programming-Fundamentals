using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(CalcFactorial(input));
        }
        public static BigInteger CalcFactorial(BigInteger n)
        {
            BigInteger factorial = 1;
            do
            {
                factorial = factorial * n;
                n--;
            } while (n>1);
            return factorial;
        }
    }
}
