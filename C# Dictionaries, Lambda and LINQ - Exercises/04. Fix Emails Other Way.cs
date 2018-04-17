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
                if (mail.EndsWith(".us") || mail.EndsWith(".uk"))
                {
                    continue;
                }
                if (!mailbook.ContainsKey(names))
                {
                    mailbook.Add(names, mail);
                }
                else
                {
                    mailbook[names] = mail;
                }

                commands = Console.ReadLine();

            }

            foreach (var useres in mailbook)
            {
                
                    Console.WriteLine($"{useres.Key} -> {useres.Value} ");
            }
        }
    }
}

