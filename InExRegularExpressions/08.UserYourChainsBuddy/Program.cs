using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.UserYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();
            string pattern = @"<p>(.+?)<\/p>";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(textInput);
            string preDecryption = string.Empty;
            foreach (Match match in matches)
            {
                preDecryption += match.Groups[1].Value;
            }
            preDecryption = Regex.Replace(preDecryption, @"[^a-z0-9]", " ");
            preDecryption = Regex.Replace(preDecryption, @"\s+", " ");
            StringBuilder decryption = new StringBuilder();
            foreach (char character in preDecryption)
            {
                if (character >= 'a' && character <= 'm')                
                    decryption.Append((char)(character + 13));
                
                else if (character >= 'n' && character <= 'z')                
                    decryption.Append((char)(character - 13));

                else
                    decryption.Append(character);
            }
            Console.WriteLine(decryption.ToString());
        }
    }
}
