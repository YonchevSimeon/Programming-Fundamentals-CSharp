using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> data = new List<char>();

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int index = start; index <= end; index++)
            {
                data.Add(Convert.ToChar(index));
            }
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
