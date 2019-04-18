using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            const double precision = 0.000001;

            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double middle = Math.Abs(firstNumber - secondNumber);
            bool output = middle <= precision;
            Console.WriteLine(output);
        }
    }
}
