using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());
            char charThree = char.Parse(Console.ReadLine());
            Console.WriteLine($"{charThree}{charTwo}{charOne}");
        }
    }
}
