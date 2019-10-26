using System;
using System.Collections.Generic;
using System.Linq;

namespace EncryptSortandPrintArray
{
    class EncryptSortandPrintArray
    {
        static void Main()
        {
            int line = int.Parse(Console.ReadLine());
            string vowels = "aAeEiIoOuU";
            //string constants = "BbcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXyYzZ";
            char[] vowelsArr = vowels.ToCharArray();
            //char[] constantsArr = constants.ToCharArray();

            List<int> total = new List<int>();
            for (int i = 0; i < line; i++)
            {
                string word = Console.ReadLine();
                char[] letters = word.ToCharArray();


                int sum = 0;

                for (int j = 0; j < letters.Length; j++)
                {
                    char currentLetter = letters[j];
                    if (vowelsArr.Contains(currentLetter))
                    {
                        sum += letters[j] * letters.Length;
                    }
                    else
                    {
                        sum += letters[j] / letters.Length;
                    }
                }
               // Console.WriteLine(sum);
                total.Add(sum);
                total.Sort();
            }
            for (int i = 0; i <total.Count; i++)
            {
                Console.WriteLine(total[i]);
            }

        }
    }
}

