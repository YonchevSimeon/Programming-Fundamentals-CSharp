using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;
            while (true)
            {
                int n;
                bool isDigits = int.TryParse(input, out n);
                if (!isDigits)
                    break;
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine(counter);
        }
    }
}
