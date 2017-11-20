namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class PrimeChecker
    {
        public static List<int> GetPrimes(int start, int end)
        {
            List<int> primesList = new List<int>();
            for (int num = start; num <= end; num++)
            {
                if (num < 2)
                {
                    num = 2;
                }
                bool prime = true;
                double numSqrt = Math.Sqrt(num);
                for (int div = 2; div <= numSqrt; div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    primesList.Add(num);
                }
            }
            return primesList;
        }
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> primes = GetPrimes(start, end);
            Console.WriteLine(string.Join(", ", primes));
        }
    }
}
