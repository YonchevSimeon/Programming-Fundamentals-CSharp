using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPointDistance = CalculatingDistance(x1, y1);
            double secondPointDistance = CalculatingDistance(x2, y2);

            
        }
        

        static double CalculatingDistance(double x, double y)
        {
            double distance = Math.Sqrt((x * x) + (y * y));
            return distance;
        }
    }
}
