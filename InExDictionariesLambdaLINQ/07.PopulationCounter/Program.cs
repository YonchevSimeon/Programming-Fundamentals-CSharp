using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> database = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "report")
            {
                string[] inputTokens = input.Split('|');
                string city = inputTokens[0];
                string country = inputTokens[1];
                long population = long.Parse(inputTokens[2]);

                if (!database.ContainsKey(country))
                {
                    database[country] = new Dictionary<string, long>();
                }
                if (!database[country].ContainsKey(city))
                {
                    database[country][city] = population;
                }
                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string, Dictionary<string, long>> country in database.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (KeyValuePair<string, long> city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
