using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string validInputPattern = @"([^&?]+)=([^&?]+)";
            string trimingPattern = @"(%20|\+)+";
            string commandLine = Console.ReadLine();
            while(commandLine != "END")
            {
                MatchCollection matches = Regex.Matches(commandLine, validInputPattern);
                Dictionary<string, List<string>> sortedMatches = new Dictionary<string, List<string>>();
                for (int index = 0; index < matches.Count; index++)
                {
                    string field = matches[index].Groups[1].Value;
                    string value = matches[index].Groups[2].Value;
                    field = Regex.Replace(field, trimingPattern, " ").Trim();
                    value = Regex.Replace(value, trimingPattern, " ").Trim();
                    if (!sortedMatches.ContainsKey(field))
                        sortedMatches[field] = new List<string>();
                    sortedMatches[field].Add(value);
                }
                foreach (KeyValuePair<string, List<string>> kvp in sortedMatches)
                {
                    Console.Write($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
                }
                Console.WriteLine();
                commandLine = Console.ReadLine();
            }
        }
    }
}
