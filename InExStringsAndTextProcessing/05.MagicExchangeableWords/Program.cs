using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            string firstWord = new string(inputTokens[0].Distinct().ToArray());
            string secondWord = new string(inputTokens[1].Distinct().ToArray());
            if (firstWord.Length.Equals(secondWord.Length))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}

