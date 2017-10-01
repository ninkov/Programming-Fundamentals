using System;

namespace TestNumbers
{
    class TestNumbers
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int maximumSumBoundary = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 0;

            for (int i = firstNum; i >= 1; i--)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    sum += (i * j) * 3;
                    counter++;

                    //Console.Write($"{i}{j} ");
                    if (sum >= maximumSumBoundary)
                    {
                        Console.WriteLine(counter + " combinations");
                        Console.WriteLine($"Sum: {sum} >= {maximumSumBoundary}");
                        return;
                    }
                    else if (sum < maximumSumBoundary)
                    {
                        continue;
                    }
                }

            }
            if (sum < maximumSumBoundary)
            {
                Console.WriteLine(counter + " combinations");
                Console.WriteLine($"Sum: {sum}");
            }
            //Console.WriteLine(sum);
            //Console.WriteLine(counter);
        }
    }
}
