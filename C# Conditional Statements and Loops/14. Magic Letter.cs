using System;

namespace MagicLetter
{
    class MagicLetter
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            for (char i = firstChar; i <= secondChar; i++)
            {
                for (char j = firstChar; j <= secondChar; j++)
                {
                    for (char k = firstChar; k <= secondChar; k++)
                    {
                        if (i != thirdChar && j != thirdChar && k != thirdChar)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
