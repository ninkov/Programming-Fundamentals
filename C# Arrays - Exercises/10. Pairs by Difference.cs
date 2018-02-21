using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
   public class PairsByDifference
    {
        public static void Main()
        {
		int[] numbers = Console.ReadLine()
			.Split
			(new[]{' '},StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToArray();
		
		int differences = int.Parse(Console.ReadLine());
									
		var counter = 0;
		
		for(int i = 0;i < numbers.Length; i++)
		{
			//int currentNum = numbers[i];
			for(int j = i;j<numbers.Length;j++)
			{
				if(Math.Abs(numbers[i]-numbers[j])==differences)
				{
					counter++;
				}
			}
		}
			Console.WriteLine(counter);
	}
  }
}
