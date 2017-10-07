using System;

namespace ReversedChars
{
    class ReversedChars
    {
        static void Main()
        {
            string result = string.Empty;

            int count = 0;
            while (count < 3)
            {
                count++;
                char input = char.Parse(Console.ReadLine());
                result = input + result;
            }
            Console.Write(result);
        }
    }
}
