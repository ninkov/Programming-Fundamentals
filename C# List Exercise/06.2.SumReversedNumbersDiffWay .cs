using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbersDiff
{
    class SumReversedNumbersDiff
    {
        static void Main()
        {
            List<string> inputList = Console.ReadLine()
                                            .Split(new char[] { ' ' }
                                                   , StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();
            int result = 0;
            for (int i = 0; i < inputList.Count; i++)
            {
                string currentNum = inputList[i];
                string revesedNum = string.Empty;

                for (int j = currentNum.Length - 1; j >= 0; j--)
                {
                    revesedNum += currentNum[j];
                }
                result += int.Parse(revesedNum);
            }
            Console.WriteLine(result);
        }
    }
}

