using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();
            
            while (true)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);
                if (firstIndex > -1 && lastIndex > -1 && pattern.Length > 0)
                {
                    input = input.Remove(lastIndex, pattern.Length);
                    input = input.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    if (pattern.Length > 0)
                    {
                        pattern = pattern.Length == 1 ? pattern.Remove(0, 1) : pattern.Remove(pattern.Length / 2, 1);
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    return;
                }
            }
        }
    }
}
