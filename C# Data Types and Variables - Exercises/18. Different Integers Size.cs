using System;
using System.Numerics;
namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger input = BigInteger.Parse(Console.ReadLine());
            bool isSbyte = (sbyte.MinValue <= input) && (input <= sbyte.MaxValue);
            bool isByte = (0 <= input) && (input <= byte.MaxValue);
            bool isShort = (short.MinValue <= input) && (input <= short.MaxValue);
            bool isUshort = (0 <= input) && (input <= ushort.MaxValue);
            bool isInt = (int.MinValue <= input) && (input <= int.MaxValue);
            bool isUint = (0 <= input) && (input <= uint.MaxValue);
            bool isLong = (long.MinValue <= input) && (input <= long.MaxValue);

            if (isSbyte || isByte || isShort || isUshort || isInt || isUint || isLong)
            {
                Console.WriteLine("{0} can fit in:", input);
                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (isByte)
                {
                    Console.WriteLine("* byte");
                }
                if (isShort)
                {
                    Console.WriteLine("* short");
                }
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (isInt)
                {
                    Console.WriteLine("* int");
                }
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }
                if (isLong)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}
