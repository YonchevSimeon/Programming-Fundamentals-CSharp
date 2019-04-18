using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "JOKER")
            {
                List<string> inputTokens = input.Split(new string[] { ": ", ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!database.ContainsKey(inputTokens[0]))
                {
                    database[inputTokens[0]] = new List<string>();
                }
                for (int index = 1; index < inputTokens.Count; index++)
                {
                    if (!database[inputTokens[0]].Contains(inputTokens[index]))
                    {
                        database[inputTokens[0]].Add(inputTokens[index]);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string, List<string>> person in database)
            {
                int currentSum = 0;
                foreach (string pair in person.Value)
                {
                    currentSum += GetCurrentPairSum(pair);
                }
                Console.WriteLine($"{person.Key}: {currentSum}");
            }
        }
        private static int GetCurrentPairSum(string pair)
        {
            int currentValue = GetCurrentValue(pair.Substring(0, pair.Length - 1));
            int currentSuit = GetCurrentSuit(pair[pair.Length - 1]);
            return currentValue * currentSuit;
        }
        private static int GetCurrentSuit(char suit)
        {
            switch (suit)
            {
                case 'S':  return 4;
                case 'H': return 3;
                case 'D': return 2;
                case 'C': return 1;
                default: return 0;
            }
        }
        private static int GetCurrentValue(string value)
        {
            switch (value)
            {
                case "J": return 11;
                case "Q": return 12;
                case "K": return 13;
                case "A": return 14;
                default: return int.Parse(value);
            }
        }
    }
}
