using System;
namespace EnglishNameofLastDigit
{
    class EnglishNameofLastDigit
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            //Console.WriteLine(num % 10);
            long result = EnglishNameInLastDigit(num);
            switch (Math.Abs(result))
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 0:
                    Console.WriteLine("zero");
                    break;

            }
            // Console.WriteLine(result);
        }
        static long EnglishNameInLastDigit(long n)
        {
            long result = (n % 10);

            return result;
        }
    }
}
