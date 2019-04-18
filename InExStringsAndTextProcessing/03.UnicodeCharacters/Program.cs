using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //List<string> result = input.Select(t => $"\\{Convert.ToUInt16(t):X4}").ToList();
            //Console.WriteLine(string.Join("", result));
            foreach (char character in input)
            {
                Console.Write($"\\u{(int)character:x4}");
            }
            Console.WriteLine();
        }
    }
}
