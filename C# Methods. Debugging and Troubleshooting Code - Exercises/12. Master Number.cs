namespace MasterNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MasterNumber
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                
                if (IsDividedBySeven(i) && IsSimmetric(i.ToString()))
                {
                    Console.WriteLine(i);
                }
            }
        }


        public static bool IsSimmetric(string num)
        {
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    return false;
                }

            }
            return true;
        }
        public static bool IsDividedBySeven(int num)//work
        {
            bool isDivided = false;
            bool evenDigit = false;
            int sum = 0;
            while (num != 0)
            {
                int lastNum = num % 10;
                if (lastNum % 2 == 0)
                {
                    evenDigit = true;
                }
                sum += lastNum;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                isDivided = true;
            }

            if (evenDigit && isDivided)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
