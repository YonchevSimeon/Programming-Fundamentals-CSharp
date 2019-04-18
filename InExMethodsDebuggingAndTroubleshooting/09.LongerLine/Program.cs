using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintTheLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void PrintTheLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double secondLine = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            if(firstLine >= secondLine)
            {
                bool closerPoint = CloserPointBetweenTwoPoints(CalculatingDistance(x1, y1), CalculatingDistance(x2, y2));
                if (closerPoint)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                bool closerPoint = CloserPointBetweenTwoPoints(CalculatingDistance(x3, y3), CalculatingDistance(x4, y4));
                if (closerPoint)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
        static bool CloserPointBetweenTwoPoints(double onePointDistance, double anotherPointDistance)
        {
            bool isFirstDistanceCloser = false;
            if (onePointDistance <= anotherPointDistance)
            {
                isFirstDistanceCloser = true;
            }
            return isFirstDistanceCloser;
        }
        static double CalculatingDistance(double x, double y)
        {
            double distance = Math.Sqrt((x * x) + (y * y));
            return distance;
        }
    }
}
