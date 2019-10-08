using System;

namespace Login
{
    class Program
    {
        static void Main()
        {
            string userName = Console.ReadLine();
            string pasword = string.Empty;
            int countWrongLogin = 0;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                pasword += userName[i];
            }
            string curentUserPass = Console.ReadLine();
            while (curentUserPass != pasword)
            {
                countWrongLogin++;

                if (countWrongLogin == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;

                }
                Console.WriteLine("Incorrect password. Try again.");
                curentUserPass = Console.ReadLine();
            }
            Console.WriteLine($"User {userName} logged in.");
        }
    }
}

