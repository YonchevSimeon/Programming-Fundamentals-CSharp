using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> database = new Dictionary<string, string>();

            string currentInput = Console.ReadLine();
            while (currentInput != "END")
            {
                List<string> currentInputTokens = currentInput.Split(' ').ToList();
                if(currentInputTokens[0] == "A")
                {
                    if (!database.ContainsKey(currentInputTokens[1]))
                    {
                        database[currentInputTokens[1]] = string.Empty;
                    }
                    database[currentInputTokens[1]] = currentInputTokens[2];
                }
                else
                {
                    if (database.ContainsKey(currentInputTokens[1]))
                    {
                        Console.WriteLine($"{currentInputTokens[1]} -> {database[currentInputTokens[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {currentInputTokens[1]} does not exist.");
                    }
                }
                currentInput = Console.ReadLine();
            }
        }
    }
}
