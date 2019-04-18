using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while(command != "Odd" || command != "Even")
            {
                List<string> currentCommandTokens = command.Split(' ').ToList();
                if (command.Contains("Insert"))
                {
                    int currentIndex = int.Parse(currentCommandTokens[2]);
                    int currentElement = int.Parse(currentCommandTokens[1]);
                    input.Insert(currentIndex, currentElement);
                }
                else if(command.Contains("Delete"))
                {
                    int currentElementValue = int.Parse(currentCommandTokens[1]);
                    input.RemoveAll(x => x == currentElementValue);
                }
                else if (command.Contains("Odd"))
                {
                    Console.WriteLine(string.Join(" ", input.Where(x => x % 2 != 0)));
                    return;
                }
                else
                {
                    Console.WriteLine(string.Join(" ", input.Where(x => x % 2 == 0)));
                    return;
                }
                command = Console.ReadLine();
            }
            
            
        }
    }
}
