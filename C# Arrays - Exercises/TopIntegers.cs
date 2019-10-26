using System;
using System.Linq;

namespace TopIntegers
{
    class TopIntegers
    {
        static void Main()
        {
            int[] elementOfArr = Console.ReadLine().
            Split(' ').Select(int.Parse).
                ToArray();

            for (int i = 0; i < elementOfArr.Length; i++)
            {
                bool bigges = true;
                for (int j = i + 1; j < elementOfArr.Length; j++)
                {
                    if (elementOfArr[i] <= elementOfArr[j])
                    {
                        bigges = false;
                    }

                }

                if (bigges==true)
                {
                    Console.Write(elementOfArr[i]+" ");
                }
            }

        }
    }
}

