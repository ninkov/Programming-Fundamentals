using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            Dictionary<string, string> mailbook = new Dictionary<string, string>();

            string names = string.Empty;
            string mail = string.Empty;

            string commands = Console.ReadLine();

            while (commands != "stop")
            {
                names = commands;
                mail = Console.ReadLine();

                if (!mailbook.ContainsKey(names))
                {
                    mailbook.Add(names, mail);
                }

                commands = Console.ReadLine();
            }

            foreach (var kvp in mailbook.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value} ");
            }
        }
    }
}

