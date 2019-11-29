using System;
using System.Collections.Generic;
using System.Linq;

namespace MiddleCharacters
{
    class TeMiddleCharactersst
    {
        static void Main()
        {
            string result = PrintMiddleChar();
            Console.WriteLine(result);
        }
        public static string PrintMiddleChar()
        {
            string text = Console.ReadLine();
            if (text.Length % 2 == 0)
            {
                return ($"{text[text.Length / 2 - 1]}{text[text.Length / 2]}");
            }
            return ($"{text[text.Length / 2]}");
        }
    }
}

