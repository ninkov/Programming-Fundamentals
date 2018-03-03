using System;
using System.Collections.Generic;
using System.Linq;
namespace AppendLists
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
                                         
            input.Reverse();                            
            var result = new List<string>();

            foreach (var numbers in input)
            {
                List<string> num = numbers.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(num);
            }
               
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
