using System;
using System.Numerics;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());
            BigInteger result = 0;
            for (int i = 0; i <= inputNum; i++)
            {
                result=(Fibonacci(i));
            }
            Console.WriteLine(result);
        }
        public static BigInteger Fibonacci(BigInteger n)
        {
            BigInteger firstNum = 0;
            BigInteger secondNumber = 1;
            for (int i = 0; i <= n; i++)
            {
                BigInteger temp = firstNum;
                firstNum = secondNumber;
                secondNumber = temp + secondNumber;
            }
            return firstNum;
        }
    }
}
