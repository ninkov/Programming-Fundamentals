namespace TripleSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TripleSum
    {
        static void Main()
        {

            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var count = 0;
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a+1; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        var sum = arr[a] + arr[b];
                        if (arr.Contains(sum))
                        {
                            Console.WriteLine(arr[a] + " + " + arr[b] + " == " + sum);

                            count++;
                            break;
                        }
                    }
                }
                        if (count==0)
                        {
                            Console.WriteLine("No");
                            break;
                        }
            }
        }

    }
}
