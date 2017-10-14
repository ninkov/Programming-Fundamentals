using System;
namespace IndexofLetters
{
    class IndexofLetters
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {((input[i]) - 'a')}");
            }
        }

    }
}
