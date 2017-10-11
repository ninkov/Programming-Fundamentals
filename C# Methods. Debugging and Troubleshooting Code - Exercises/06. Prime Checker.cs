using System;
namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            PrimeCheck(input);
        }

        private static void PrimeCheck(long number)
        {
            //int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if ((number == 1) | (number == 0) | (number < 0))
            {
                isPrime = false;

            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isPrime);
        }
    }
}
