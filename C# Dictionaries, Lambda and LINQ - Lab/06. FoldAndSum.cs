using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            var numbersInput = Console.ReadLine()
                                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();

            int k = numbersInput.Length / 4;

            var leftPart = numbersInput.Take(k).Reverse();
            var rightPart = numbersInput.Reverse().Take(k);
            var midPart = numbersInput.Skip(k).Take(k * 2).ToArray();
            var concatLeftRight = leftPart.Concat(rightPart).ToArray();
            var sum = concatLeftRight.Select((x, index) => x + midPart[index]);
           
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
