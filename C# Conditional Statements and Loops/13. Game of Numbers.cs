using System;

namespace GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = secondNumber; i >= firstNumber; i--)
            {
                for (int j = secondNumber; j >= firstNumber; j--)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        // Console.WriteLine($"{i} {j}");
                        Console.WriteLine($"Number found! {i} + {j} = {magicNumber}");
                        return;
                    }


                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");

        }
    }
}
