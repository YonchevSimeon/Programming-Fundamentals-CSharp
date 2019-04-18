using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> database = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                List<string> email = Console.ReadLine().Split('.').ToList();
                if(email[1] != "us" && email[1] != "uk")
                {
                    if (!database.ContainsKey(input))
                    {
                        database[input] = string.Empty;
                    }
                    database[input] = $"{email[0]}.{email[1]}";
                }
                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string, string> person in database)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
