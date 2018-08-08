using System;

namespace SieveOfEratosthenes
{
	class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int numberToReach = int.Parse(Console.ReadLine());//read input
            bool[] primeNumbers = new bool[numberToReach + 1];//make array

            for (int i = 0; i < primeNumbers.Length; i++)//set all true
            {
                primeNumbers[i] = true;
            }
            primeNumbers[0] = primeNumbers[1] = false;//0 and 1 is not prime

            for (int i = 2; i < primeNumbers.Length; i++)//print prime 
            {
                if (primeNumbers[i])
                {
                    Console.Write(i + " ");
                }
                for (int j = i*2; j < primeNumbers.Length; j+=i)//do not print multiplse
                {
                    primeNumbers[j] = false;
                }
            }
        }
    }
}
