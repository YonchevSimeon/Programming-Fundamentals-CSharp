using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mile = 1.60934;
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine($"{miles * mile:f2}");
        }
    }
}
