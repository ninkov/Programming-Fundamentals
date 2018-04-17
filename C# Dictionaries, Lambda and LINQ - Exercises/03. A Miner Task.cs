using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            Dictionary<string, int> mine = new Dictionary<string, int>();

            string commands = Console.ReadLine();
            //string metal = string.Empty;
            //int quantity = 0;
            while (commands != "stop")
            {
              string  metal = commands;
               int quantity = int.Parse(Console.ReadLine());

                if (!mine.ContainsKey(metal))
                {
                    mine.Add(metal, quantity);
                }
                else
                {
                    mine[metal] += quantity;
                }

                commands = Console.ReadLine();
            }

            foreach (var kvp in mine)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

