using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<double>>> database = new Dictionary<string, SortedDictionary<string, List<double>>>(); 

            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int currentInput = 0; currentInput < numberOfInputs; currentInput++)
            {
                string[] currentInputTokens = Console.ReadLine().Split(' ');
                string type = currentInputTokens[0];
                string name = currentInputTokens[1];
                double damage = currentInputTokens[2] != "null" ? double.Parse(currentInputTokens[2]) : 45;
                double health = currentInputTokens[3] != "null" ? double.Parse(currentInputTokens[3]) : 250;
                double armor = currentInputTokens[4] != "null" ? double.Parse(currentInputTokens[4]) : 10;
                if (!database.ContainsKey(type))
                {
                    database[type] = new SortedDictionary<string, List<double>>();
                }
                if (!database[type].ContainsKey(name))
                {
                    database[type][name] = new List<double>();
                }
                database[type][name] = new List<double>();
                database[type][name].Add(damage);
                database[type][name].Add(health);
                database[type][name].Add(armor);
            }
            foreach (KeyValuePair<string, SortedDictionary<string, List<double>>> color in database)
            {
                Console.WriteLine($"{color.Key}::({color.Value.Values.Average(x => x[0]):f2}/{color.Value.Values.Average(x => x[1]):f2}/{color.Value.Values.Average(x => x[2]):f2})");
                foreach (KeyValuePair<string, List<double>> name in color.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]:f0}, health: {name.Value[1]:f0}, armor: {name.Value[2]:f0}");
                }
            }
            
        }
    }
}
