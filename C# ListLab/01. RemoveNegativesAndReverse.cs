using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                            .ToList();
            
            var result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                var currentNum = input[i];
                if (currentNum > 0)
                {
                    result.Add(currentNum);

                }
                result.Reverse();
            }
			if (result.Count > 0)
			{
				Console.WriteLine(string.Join(" ",result));
            }
            else
            {
				Console.WriteLine("empty");
            }
        }
    }
}
