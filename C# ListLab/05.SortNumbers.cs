using System;
using System.Collections.Generic;
using System.Linq;
namespace SortNumbers
{
    class SortNumbers
    {
        static void Main()
        {
            List<decimal> inputNum = Console.ReadLine()
                                            .Split(' ')
                                            .Select(decimal.Parse)
                                            .ToList(); 
            inputNum.Sort();
            Console.WriteLine(string.Join(" <=",inputNum));
        }
    }
}
