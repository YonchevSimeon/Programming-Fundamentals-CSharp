using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string pattern = @"([\w.-]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputText);
            foreach (Match match in matches)
            {
                string email = match.ToString();
                if (!email.StartsWith(".") && !email.StartsWith("_") && !email.StartsWith("-")
                    && !email.EndsWith(".") && !email.EndsWith("_") && !email.EndsWith("-"))
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
