using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> database = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                int currentInputValue = int.Parse(Console.ReadLine());
                if (!database.ContainsKey(input))
                {
                    database[input] = new int();
                }
                database[input] += currentInputValue;
                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string, int> resource in database)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
