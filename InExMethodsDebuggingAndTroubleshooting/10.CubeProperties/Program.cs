using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfTheCube = double.Parse(Console.ReadLine());
            string calculationType = Console.ReadLine();
            Console.WriteLine($"{PrintCalculation(sideOfTheCube, calculationType):f2}");
        }
        static double PrintCalculation(double sideOfTheCube, string calculationType)
        {
            double output = 0.0;
            if(calculationType == "face")
            {
                output = Math.Sqrt(2 * (Math.Pow(sideOfTheCube, 2)));
            }
            else if(calculationType == "space")
            {
                output = Math.Sqrt(3 * (Math.Pow(sideOfTheCube, 2)));
            }
            else if(calculationType == "volume")
            {
                output = Math.Pow(sideOfTheCube, 3);
            }
            else
            {
                output = 6 * Math.Pow(sideOfTheCube, 2);
            }
            return output;
        }
    }
}
