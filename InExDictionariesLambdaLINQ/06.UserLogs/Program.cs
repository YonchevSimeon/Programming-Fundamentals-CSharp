using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> database = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                List<string> inputTokens = input.Split(new string[] { "IP=", "user=", " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string ipAddress = inputTokens[0];
                string user = inputTokens[2];
                if (!database.ContainsKey(user))
                {
                    database[user] = new Dictionary<string, int>();
                }
                if (!database[user].ContainsKey(ipAddress))
                {
                    database[user][ipAddress] = new int();
                }
                database[user][ipAddress]++;                
                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string, Dictionary<string, int>> person in database.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{person.Key}:");
                int count = person.Value.Count;
                int counter = 0;
                foreach (KeyValuePair<string, int> ipAddress in person.Value)
                {
                    
                    counter++;
                    if (counter < count)
                    {
                        Console.Write($"{ipAddress.Key} => {ipAddress.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ipAddress.Key} => {ipAddress.Value}.");
                    }
                }
            }
        }
    }
}
