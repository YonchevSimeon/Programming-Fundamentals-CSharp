using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> database = new Dictionary<string, Dictionary<string, long>>();
            int numberOfLogs = int.Parse(Console.ReadLine());
            for (int log = 0; log < numberOfLogs; log++)
            {
                string[] currentLog = Console.ReadLine().Split(' ');
                string ipAddress = currentLog[0];
                string username = currentLog[1];
                int duration = int.Parse(currentLog[2]);
                if (!database.ContainsKey(username))
                {
                    database[username] = new Dictionary<string, long>();
                }
                if (!database[username].ContainsKey(ipAddress))
                {
                    database[username][ipAddress] = new long();
                }
                database[username][ipAddress] += duration;
            }
            foreach (KeyValuePair<string, Dictionary<string, long>> username in database.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{username.Key}: {username.Value.Values.Sum()} [{string.Join(", ", username.Value.Keys.OrderBy(x => x))}]");
            }
        }
    }
}
