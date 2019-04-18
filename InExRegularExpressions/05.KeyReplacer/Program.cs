using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keysInput = Console.ReadLine();
            string textInput = Console.ReadLine();
            string keysPattern = @"^([A-z]+)(\<|\||\\).*(\<|\||\\)([A-z]+)$";
            Match keys = Regex.Match(keysInput, keysPattern);
            string startKey = keys.Groups[1].Value;
            string endKey = keys.Groups[4].Value;
            string textPattern = $@"{startKey}(.*?){endKey}";
            MatchCollection matches = Regex.Matches(textInput, textPattern);
            StringBuilder output = new StringBuilder();
            foreach (Match match in matches)
            {
                output.Append(match.Groups[1].Value);
            }
            string convertedOutput = output.ToString();
            Console.WriteLine(convertedOutput.Length > 0 ? convertedOutput : "Empty result");
        }
    }
}
