using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputTokens = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> commandTokens = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int takeElements = commandTokens[0];
            int deleteElement = commandTokens[1];
            int searchElement = commandTokens[2];
            inputTokens.RemoveRange(takeElements , inputTokens.Count - takeElements);
            inputTokens.RemoveRange(0, deleteElement);
            if (inputTokens.Contains(searchElement))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
