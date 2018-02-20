namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Test
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            bool[] primes = new bool[number+1];

            for (int i = 2; i < primes.Length; i++)//indexed by integers 2 to n
            {                                      //initially all set to true.
                primes[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (primes[i])// if A[i] is true:
                {
                    for (int j = i * i; j <= number; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }
            //add index to result
            List<int> result = new List<int>();

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    result.Add(i);//Output: all i such that A[i] is true.
                }
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}

