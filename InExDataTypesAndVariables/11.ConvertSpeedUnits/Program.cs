using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            const int metersPerMile = 1609;

            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalSeconds = (hours * 60 * 60) + (minutes * 60) + (seconds);

            float metersPerSecond = (float)distanceInMeters / totalSeconds;
            float kilometersPerHour = ((float)distanceInMeters / 1000) / ((float)totalSeconds / 60 / 60);
            float milesPerHour = ((float)distanceInMeters / metersPerMile) / ((float)totalSeconds / 60 / 60);

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
