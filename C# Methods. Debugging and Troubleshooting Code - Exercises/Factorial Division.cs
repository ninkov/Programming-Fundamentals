using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace FactorialDivision
{
    class FactorialDivision
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double divisionOfTwoNum = (double)CalculateFactorial(firstNumber) / (double)CalculateFactorial(secondNumber);
            Console.WriteLine($"{divisionOfTwoNum:f2}");
        }

        private static BigInteger CalculateFactorial(BigInteger numToCalcFactorial)
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= numToCalcFactorial; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}

