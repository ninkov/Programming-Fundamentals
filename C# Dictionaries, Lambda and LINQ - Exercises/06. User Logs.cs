using System;
using System.Linq;
using System.Collections.Generic;

namespace UserLogs
{
    class Program
    {
        static void Main()
		{   
			string line = Console.ReadLine();         
			Dictionary<string, Dictionary<string, int>> userLogs = new Dictionary<string, Dictionary<string, int>>();

			while (line != "end")
            {
				string[] separators = { "message", "=" };

				var ipAndUsername = line.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();


				string ip = ipAndUsername[1];

				string username = ipAndUsername[3];

				if (!userLogs.ContainsKey(username))
				{
					userLogs.Add(username, new Dictionary<string, int> { { ip, 1 } });
				}
				else               
				{
					if (userLogs[username].ContainsKey(ip))
					{
						userLogs[username][ip]++;
					}
					else
					{


						userLogs[username].Add(ip, 1);
					}
				}


				line = Console.ReadLine(); 
            }

            foreach (var log in userLogs.OrderBy(logs => logs.Key))
            {
				Console.WriteLine($"{log.Key}:");
                
				foreach (var item in userLogs[log.Key])
                {
                    if (item.Key != log.Value.Keys.Last())
                    {
                        Console.Write("{0}=> {1}, ", item.Key, item.Value);
                    }
                    else
                    {
                        Console.WriteLine("{0}=> {1}.", item.Key, item.Value);
                    }

                }

			}
		}
	}
}

