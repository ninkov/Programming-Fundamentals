using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateandSum
{
    class RotateandSum
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] sum = new int[input.Length];
            int timesToRotate = int.Parse(Console.ReadLine());

            for (int i = 0; i < timesToRotate; i++)
            {
                RotateArray(input);

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] = sum[j] + input[j];
                }

            }
            Console.WriteLine(string.Join(" ",sum));
        }

        private static void RotateArray(int[] input)
        {
            var lastNumber = input.Last();
            for (int i = input.Length-1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = lastNumber;
        }
    }
}
