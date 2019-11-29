using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ChangeList
{
    class ChangeList
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                result = numbers;
                string[] task = command.Split();
                if (task[0] == "Delete")
                {
                    int numberToDelete = int.Parse(task[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] != numberToDelete)
                        {
                            numbers.Remove(numberToDelete);
                           // numbers.RemoveAll(n => n == numberToDelete);
                        }
                    }

                }
                if (task[0] == "Insert")
                {
                    int element = int.Parse(task[1]);
                    int index = int.Parse(task[2]);
                    numbers.Insert(index, element);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}

