using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = Circle.ReadCircle(Console.ReadLine().Split(' ').Select(double.Parse).ToArray());
            Circle secondCircle = Circle.ReadCircle(Console.ReadLine().Split(' ').Select(double.Parse).ToArray());
            string intersection = Circle.Intersection(firstCircle, secondCircle);
            Console.WriteLine(intersection);



        }
    }
    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }

        public static Circle ReadCircle(double[] inputTokens)
        {
            return new Circle
            {
                X = inputTokens[0],
                Y = inputTokens[1],
                Radius = inputTokens[2]
            };
        }

        public static string Intersection(Circle firstCircle, Circle secondCircle)
        {
            double distance = Math.Sqrt(Math.Pow((secondCircle.X - firstCircle.X), 2) + Math.Pow((secondCircle.Y - firstCircle.Y), 2));
            if(distance <= firstCircle.Radius + secondCircle.Radius)
            {
                return "Yes";
            }
            return "No";
        }
    }
}
