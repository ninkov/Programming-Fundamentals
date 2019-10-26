using System;
using System.Linq;

namespace CommonElements
{
    class CommonElements
    {
        static void Main()
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {
                    if (second[i]==first[j])
                    {
                        Console.Write($"{second[i]} ");
                    }
                }
            }
        }
    }
}

