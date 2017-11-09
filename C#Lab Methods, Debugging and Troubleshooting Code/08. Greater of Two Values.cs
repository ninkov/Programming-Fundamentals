namespace GreaterofTwoValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class GreaterofTwoValues
    {
        static void Main()
        {
            var type = Console.ReadLine().ToLower();
            if (type == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                int max = GetMax(firstValue, secondValue);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(first, second);

                Console.WriteLine(max);

            }
        }

        public static int GetMax(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            return secondValue;
        }
        public static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0)
            {
                return firstValue;
            }
            return secondValue;
        }
        public static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            return secondValue;
        }
    }
}
