using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int output = Convert.ToInt32(input, 16);
            Console.WriteLine(output);
        }
    }
}
