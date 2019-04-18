using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] input = Console.ReadLine().ToCharArray();
            for (int index = 0; index < input.Length; index++)
            {
                for (int alphabetIndex = 0; alphabetIndex < alphabet.Length; alphabetIndex++)
                {
                    if(alphabet[alphabetIndex] == input[index])
                    {
                        Console.WriteLine($"{input[index]} -> {alphabetIndex}");
                    }
                }
            }
        }
    }
}
