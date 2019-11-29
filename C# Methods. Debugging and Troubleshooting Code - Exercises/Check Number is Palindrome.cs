using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace FactorialDivision
{
    class FactorialDivision
    {
        static void Main()
        {
            CheckNumIsPalindrome();

        }

        private static void CheckNumIsPalindrome()
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] == command[command.Length - 1 - i])
                    {
                        Console.WriteLine("true");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("false");
                        break;
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}

