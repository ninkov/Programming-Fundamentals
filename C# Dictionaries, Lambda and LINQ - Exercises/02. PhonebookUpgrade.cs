using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
            
            while (command[0] != "END")
            {
                
                
                if (command[0] == "A")
                {
                    if (!phonebook.ContainsKey(command[1]))
                    {
                        phonebook.Add(command[1],command[2]);
                    }
                    else
                    {
                        phonebook[command[1]] = command[2];
                    }
                }
                else if(command[0] == "S")
                {
                    if (!phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                    }
                }
                else if (command[0] == "ListAll")
                {
                    foreach (var kvp in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }

                command = Console.ReadLine()
                                 .Split(new char[] { ' ' }
                                        , StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();



            }
        }
    }
}
