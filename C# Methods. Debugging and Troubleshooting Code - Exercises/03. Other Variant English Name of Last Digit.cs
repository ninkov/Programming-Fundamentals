using System;
namespace EnglishNameofLastDigit
{
    class EnglishNameofLastDigit
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            long result = EnglishNameInLastDigit(Math.Abs(num));

            if (result == 1)
            {
                Console.WriteLine("one");
            }
            if (result == 2)
            {
                Console.WriteLine("two");
            }
            if (result == 3)
            {

                Console.WriteLine("three");
            }
            if (result == 4)
            {

                Console.WriteLine("four");
            }
            if (result == 5)
            {

                Console.WriteLine("five");
            }
            if (result == 6)
            {

                Console.WriteLine("six");
            }

            if (result == 7)
            {
                Console.WriteLine("seven");
            }
            if (result == 8)
            {

                Console.WriteLine("eight");
            }
            if (result == 9)
            {

                Console.WriteLine("nine");
            }
            if (result == 0)
            {
                Console.WriteLine("zero");
            }

        }


        // Console.WriteLine(result);
        static long EnglishNameInLastDigit(long n)
        {
            long result = (n % 10);

            return result;
        }
    }
}

