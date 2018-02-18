namespace Test
{
    using System;
    using System.Linq;
    class Test
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            int[] firstPart = numbers.Take(k).Reverse().ToArray();
            int[] midPart = numbers.Skip(k).Take(2 * k).ToArray();
            int[] secodPart = numbers.Skip(3 * k).Take(k).Reverse().ToArray();


            var left = firstPart.Concat(secodPart).ToArray();

            for (int i = 0; i < left.Length; i++)
            {
                int res = midPart[i] + left[i];
                Console.Write(res + " ");
            }
            Console.WriteLine();

        }
    }
}

