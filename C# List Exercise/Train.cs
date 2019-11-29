using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Train
{
    class Train
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] task = command.Split();
                if (task[0] == "Add")
                {
                    int wagonToAdd = int.Parse(task[1]);
                    wagons.Add(wagonToAdd);
                }
                else
                {
                    int pasangerToAdd = int.Parse(task[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (pasangerToAdd + wagons[i] <= maxCapacity)
                        {
                            wagons[i] += pasangerToAdd;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}

