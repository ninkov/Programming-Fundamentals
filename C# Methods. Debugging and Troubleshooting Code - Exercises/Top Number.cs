using System;

namespace TopNumber
{
    class TopNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            IsTopNumber(number);
        }

        private static void IsTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                bool oddDigit = false;
                int temp = i;
                while (temp > 0)
                {
                    //if (temp == 0)
                    //{
                    //    break;
                    //}
                    int lastDigit = temp % 10;
                    sum += lastDigit;
                    if (lastDigit % 2 != 0)
                    {
                        oddDigit = true;
                    }
                    temp /= 10;
                }
                if (sum % 8 == 0 && oddDigit == true)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}