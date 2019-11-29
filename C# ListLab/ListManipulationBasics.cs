using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ListManipulationBasics
{
    class ListManipulationBasics
    {
        static void Main()
        {
            List<int> inputNum = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();
            while (commands != "end")
            {
                string[] token = commands.Split(" ");

                if (token[0] == "Add")
                {
                    int addNum = int.Parse(token[1]);
                    inputNum.Add(addNum);
                }
                else if (token[0] == "Remove")
                {
                    int numToRemove = int.Parse(token[1]);
                    inputNum.Remove(numToRemove);
                }
                else if (token[0] == "RemoveAt")
                {
                    int index = int.Parse(token[1]);
                    inputNum.RemoveAt(index);
                }
                else if (token[0] == "Insert")
                {
                    int number = int.Parse(token[1]);
                    int index = int.Parse(token[2]);
                    inputNum.Insert(index, number);
                }
                commands = Console.ReadLine();
            }
            foreach (var num in inputNum)
            {
                Console.Write(num + " ");
            }
        }
    }
}

