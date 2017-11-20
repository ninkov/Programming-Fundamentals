namespace NumbersinReversedOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class NumbersinReversedOrder
    {
        static void Main()
        {
            string num = Console.ReadLine();
            PrintNumberInReversOrder(num);
        }

        public static void PrintNumberInReversOrder(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                var revers = num[num.Length - 1 - i];
              Console.Write(revers);
            }
            Console.WriteLine();
        }
    }
}
