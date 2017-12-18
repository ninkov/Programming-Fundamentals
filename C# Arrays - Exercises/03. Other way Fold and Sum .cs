using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();//initialize the array

            int k = input.Length / 4;

            int[] left = input.Take(k).Reverse().ToArray();
            int[] right = input.Reverse().Take(k).ToArray();

            int[] mid = input.Skip(k).Take(2 * k).ToArray();//take the midl part, and create first row
            int[] newArr = left.Concat(right).ToArray();//concat arr1 arr2, and create seconnd row 

            for (int i = 0; i < mid.Length; i++)
            {
                mid[i] += newArr[i];//Sum the first and the second rows.
            }
            Console.WriteLine(string.Join(" ",mid));

        }
    }
}
