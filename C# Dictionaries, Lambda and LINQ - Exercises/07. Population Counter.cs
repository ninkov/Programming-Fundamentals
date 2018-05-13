using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> populationCounter = new Dictionary<string, Dictionary<string, long>>();


            string line = string.Empty;

            while ((line = Console.ReadLine())!="report")
            {

                string[] tokens = line.Split('|');
                string city = tokens[0];
                string country = tokens[1];
                long population = long.Parse(tokens[2]);

                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter.Add(country, new Dictionary<string, long>());
                }
                if (!populationCounter[country].ContainsKey(city))
                {
                    populationCounter[country].Add(city, population);
                }
                else
                {
                    populationCounter[country][city] += population;
                }
            }
           

            foreach (var counrty in populationCounter.OrderByDescending(c => c.Value.Sum(x => x.Value)) )
            {
                string countryName = counrty.Key;
                long total = counrty.Value.Sum(x => x.Value);

                Console.WriteLine($"{countryName} (total population: {total})");
           
                Dictionary<string, long> sortedCity = counrty.Value.OrderByDescending(t => t.Value)
                                                             .ToDictionary(x => x.Key ,x => x.Value);
				
                foreach (var town in sortedCity)
				{
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
				}
            }
        }
    }
}

