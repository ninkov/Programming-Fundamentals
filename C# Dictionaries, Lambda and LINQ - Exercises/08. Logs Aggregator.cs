using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();
			int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
				string line = Console.ReadLine();
                string[] tokens = line
                    .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                string ip = tokens[0];
                string user = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (!logs.ContainsKey(user))
                {

                    logs.Add(user, new Dictionary<string, int>());
                }
                if (!logs[user].ContainsKey(ip))
                {
                    logs[user].Add(ip, duration);
                }
                else
                {

                    logs[user][ip] += duration;
                }
            }

            foreach (var log in logs.OrderBy(u => u.Key))
            {
                string username = log.Key;
                int totalDuration = log.Value.Sum(i => i.Value);

                string[] ips = log
                    .Value
                    .Keys.OrderBy(i =>i)
                    .ToArray();
                Console.WriteLine($"{username}: {totalDuration} [{string.Join(", ",ips)}]");
            }

        }
    }
}

