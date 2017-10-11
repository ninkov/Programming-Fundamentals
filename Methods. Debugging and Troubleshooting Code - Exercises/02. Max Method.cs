using System;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(GetMax(firstNum, secondNum),thirdNum));
        }

        public static int GetMax(int a, int b)
        {
            int max = int.MinValue;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
    }
}
