using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _01.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] officalHollidays = new DateTime[] {
                new DateTime(4, 01, 01),
                new DateTime(4, 03, 03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 11, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26)
            };
            DateTime beginDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDays = 0;
            for (DateTime currentDay = beginDate; currentDay <= endDate; currentDay = currentDay.AddDays(1))
            {
                DateTime tempCurrentDays = new DateTime(4, currentDay.Month, currentDay.Day);
                if (!officalHollidays.Contains(tempCurrentDays)
                    && currentDay.DayOfWeek != DayOfWeek.Saturday
                    && currentDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }
            Console.WriteLine(workingDays);
        }
    }
}
