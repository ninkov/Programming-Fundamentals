using System;

namespace PasswordValidartor
{
    class PasswordValidator
    {
        static void Main()
        {
            string passwordToCheck = Console.ReadLine();

            bool checkPasswodLength = BetweenSixAndTen(passwordToCheck);
            bool checkIsDigitOrLetters = ConteinsDigitAndLetters(passwordToCheck);
            bool checkDigitCount = DigitsCount(passwordToCheck);

            if (!checkPasswodLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!checkIsDigitOrLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!checkDigitCount)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (checkPasswodLength&&checkIsDigitOrLetters&&checkDigitCount)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool DigitsCount(string passwordToCheck)
        {
            int count = 0;
            for (int i = 0; i < passwordToCheck.Length; i++)
            {
                if (char.IsDigit(passwordToCheck[i]))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ConteinsDigitAndLetters(string passwordToCheck)
        {
            for (int i = 0; i < passwordToCheck.Length; i++)
            {

                if (!char.IsLetterOrDigit(passwordToCheck[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool BetweenSixAndTen(string passwordToCheck)
        {
            if (passwordToCheck.Length >= 6 && passwordToCheck.Length <= 10)
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

