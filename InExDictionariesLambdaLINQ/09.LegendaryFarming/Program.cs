using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> legendaryItems = new Dictionary<string, string>();
            legendaryItems["shards"] = "Shadowmourne";
            legendaryItems["fragments"] = "Valanyr";
            legendaryItems["motes"] = "Dragonwrath";
            Dictionary<string, int> legendaryDatabase = new Dictionary<string, int>();
            legendaryDatabase["shards"] = 0;
            legendaryDatabase["fragments"] = 0;
            legendaryDatabase["motes"] = 0;
            Dictionary<string, int> junkDatabase = new Dictionary<string, int>();
            while (true)
            {
                string[] inputTokens = Console.ReadLine().ToLower().Split(' ');
                for (int index = 1; index < inputTokens.Length; index += 2)
                {
                    string material = inputTokens[index];
                    int quantity = int.Parse(inputTokens[index - 1]);
                    if(material == "shards" || material == "fragments" || material == "motes")
                    {
                        legendaryDatabase[material] += quantity;
                    }
                    else
                    {
                        if (!junkDatabase.ContainsKey(material))
                        {
                            junkDatabase[material] = 0;
                        }
                        junkDatabase[material] += quantity;
                    }
                    if(legendaryDatabase["shards"] >= 250 || legendaryDatabase["fragments"] >= 250 || legendaryDatabase["motes"] >= 250)
                    {
                        string currentMaterial = legendaryDatabase.Where(x => x.Value > 249).Select(a => a.Key).FirstOrDefault();
                        legendaryDatabase[currentMaterial] -= 250;
                        Console.WriteLine($"{legendaryItems[currentMaterial]} obtained!");
                        foreach (KeyValuePair<string, int> kvp in legendaryDatabase.OrderBy(x => -x.Value).ThenBy(x => x.Key))
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        foreach (KeyValuePair<string, int> kvp in junkDatabase.OrderBy(x => x.Key))
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        return;
                    }
                } 
            }
        }
    }
}
