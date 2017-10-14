using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int lenght = Math.Min(firstArray.Length, secondArray.Length);
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (firstArray[i] == secondArray[i] )
                {
                    count1++;
                }
                   
               
                if ((firstArray[firstArray.Length - i - 1] == secondArray[secondArray.Length - i - 1]))
                {
                    count2++;
                }
            
            }
            Console.WriteLine(Math.Max(count1,count2));

        }
    }
}
