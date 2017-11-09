namespace MultiplyEvensbyOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MultiplyEvensbyOdds
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            var result = GetMultiplySumOfEvenAndOddNumbers(n);
            Console.WriteLine(result);
        }
        public static int GetSumOfOddNumbers(int n)
        {
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                int lastDigit = n % 10;
                if (n % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;

            }
            return sum;
        }
        public static int GetSumOfEvenNumbers(int n)
        {
           
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                int lastDigit = n % 10;
                if (n % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;

            }
            return sum;
        }
        public static int GetMultiplySumOfEvenAndOddNumbers(int n)
        {
            int evenSum = GetSumOfEvenNumbers(n);
            int oddSum = GetSumOfOddNumbers(n);
            return (evenSum * oddSum);
        }
    }
}
