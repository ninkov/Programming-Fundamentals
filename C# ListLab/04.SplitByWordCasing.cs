using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main()
        {
            List<string> sentence = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            string currentWord = string.Empty;
           
            for (int i = 0; i < sentence.Count; i++)
            {
                currentWord = sentence[i];
               
                if (currentWord.All(char.IsLower))
                {
                    lowerCase.Add(currentWord);
                }
                else if (currentWord.All(char.IsUpper))
                {
                    upperCase.Add(currentWord);
                }
                else
                {
                    mixedCase.Add(currentWord);
                }
            }
            Console.WriteLine("Lower-case: " +string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: " +string.Join(", ",mixedCase));
            Console.WriteLine("Upper-case: " +string.Join(", ",upperCase));

        }
    }
}
