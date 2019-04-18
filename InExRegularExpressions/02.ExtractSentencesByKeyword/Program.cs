using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string[] inputText = Console.ReadLine().Split(new char[] {'!', '.', '?'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sentence in inputText)
            {
                string pattern = @"[^A-Za-z]";
                Regex regex = new Regex(pattern);
                string[] currentSentenceTokens = regex.Split(sentence);
                if (currentSentenceTokens.Contains(keyword))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }

        }
    }
}
