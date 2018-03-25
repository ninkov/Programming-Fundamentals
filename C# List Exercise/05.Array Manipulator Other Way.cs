using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] argument = command.Split(' ').ToArray();

                if (argument[0] == "add")//add numbers to index
                {
                    int index = int.Parse(argument[1]);
                    int element = int.Parse(argument[2]);
                    nums.Insert(index, element);
                }
                if (argument[0] == "addMany")//add many numbers from chosen index 
                {
                    int index = int.Parse(argument[1]);
                    List<int> elements = new List<int>();

                    for (int i = 2; i < argument.Length; i++)// start from second number 
                    {
                        elements.Add(int.Parse(argument[i]));
                    }
                    nums.InsertRange(index, elements);
                }

                if (argument[0] == "contains")//print index if contians, else print -1
                {
                    Console.WriteLine(nums.IndexOf(int.Parse(argument[1])));
                }

                if (argument[0] == "remove")
                {
                    nums.RemoveAt(int.Parse(argument[1]));
                }
                if (argument[0] == "shift")//easy way for shifting
                {
                    int rotations = int.Parse(argument[1]);

                    for (int i = 0; i < rotations; i++)
                    {
                        nums.Add(nums[0]);
                        nums.RemoveAt(0);
                    }
                }
                if (argument[0] == "sumPairs")
                {
                    for (int i = 0; i < nums.Count - 1; i++)
                    {
                        nums[i] = nums[i] + nums[i + 1];
                        nums.RemoveAt(i + 1);
                    }
                }



                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}
