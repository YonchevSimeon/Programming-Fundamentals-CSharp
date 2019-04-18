using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            bool isVowel = "aeiouAEIOU".IndexOf(input) >= 0;
            bool isDigit = "1234567890".IndexOf(input) >= 0;
            if (isVowel)
            {
                Console.WriteLine("vowel");
            }
            else if (isDigit)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
