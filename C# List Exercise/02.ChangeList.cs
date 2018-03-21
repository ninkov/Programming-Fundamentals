using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string manipulation = Console.ReadLine();

            while (manipulation != "Odd" && manipulation != "Even" )
            {
                string[] command = manipulation.Split(' ').ToArray();


                if (command[0] =="Delete")
                {
                    int number = int.Parse(command[1]);

                    for (int i = 0; i < nums.Count; i++)
                    {
                        nums.Remove(number);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    nums.Insert(position, element);
                
                }


                manipulation = Console.ReadLine();
            }
            if (manipulation == "Odd")
            {
                foreach (var number in nums)
                {
                    if (number % 2 != 0)
                    {
						Console.Write(number +" ");

                    }

                }
            }
            else
            {
                foreach (var number in nums)
                {
                    if (number % 2 == 0)
                    {
                        Console.Write(number +" ");
                    }
                }
            }
        }
    }
}
