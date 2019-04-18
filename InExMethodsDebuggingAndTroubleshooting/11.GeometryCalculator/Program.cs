using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            Console.WriteLine($"{GetFigureCalculations(figureType):f2}");
        }

        private static double GetFigureCalculations(string figureType)
        {
            double output = 0.0;
            if(figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                output = (side * height) / 2;
            }
            else if(figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                output = side * side;
            }
            else if(figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                output = width * height;
            }
            else
            {
                double radius = double.Parse(Console.ReadLine());
                output = Math.PI * radius * radius;
            }
            return output;
        }
    }
}
