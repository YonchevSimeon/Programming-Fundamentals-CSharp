using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTextTokens = Console.ReadLine().Split(new char[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"^[A-z][A-z0-9\d_]{2,24}$";
            Regex regex = new Regex(pattern);
            List<string> usernames = new List<string>();
            foreach (string token in inputTextTokens)
            {
                Match currMatch = regex.Match(token);
                if (currMatch.Success)
                    usernames.Add(token);
            }
            int maxLength = 0;
            int theIndex = 0;
            for (int index = 0; index < usernames.Count - 1; index++)
            {
                if(usernames[index].Length + usernames[index + 1].Length > maxLength)
                {
                    maxLength = usernames[index].Length + usernames[index + 1].Length;
                    theIndex = index;
                }
            }
            Console.WriteLine($"{usernames[theIndex]}{Environment.NewLine}{usernames[theIndex + 1]}");
        }
    }
}
