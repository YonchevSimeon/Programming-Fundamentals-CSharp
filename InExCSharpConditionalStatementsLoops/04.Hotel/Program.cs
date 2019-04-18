using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hotel> database = new List<Hotel>();
            database.Add(new Hotel { Month = "May", Studio = 50, Double = 65, Suite = 75});
            database.Add(new Hotel { Month = "October", Studio = 50, Double = 65, Suite = 75 });
            database.Add(new Hotel { Month = "June", Studio = 60, Double = 72, Suite = 82 });
            database.Add(new Hotel { Month = "September", Studio = 60, Double = 72, Suite = 82 });
            database.Add(new Hotel { Month = "July", Studio = 68, Double = 77, Suite = 89 });
            database.Add(new Hotel { Month = "August", Studio = 68, Double = 77, Suite = 89 });
            database.Add(new Hotel { Month = "December", Studio = 68, Double = 77, Suite = 89 });
            
            string month = Console.ReadLine();
            int daysToStay = int.Parse(Console.ReadLine());
            
            int index = database.FindIndex(x => x.Month == month);

            double studioApartment = database[index].Studio * daysToStay;
            double doubleApartment = database[index].Double * daysToStay;
            double suiteApartment = database[index].Suite * daysToStay;

            if (daysToStay > 7 && (month == "September" || month == "October"))
            {
                studioApartment -= database[index].Studio;
            }
            if (daysToStay > 7 && (month == "May" || month == "October"))
            {
                studioApartment *= 0.95;
            }  
            if (daysToStay > 14 && (month == "June" || month == "September"))
            {
                doubleApartment *= 0.90;
            }
            if (daysToStay > 14 && (month == "July" || month == "August" || month == "December"))
            {
                suiteApartment *= 0.85;
            }
           


            Console.WriteLine($"Studio: {studioApartment:f2} lv.");
            Console.WriteLine($"Double: {doubleApartment:f2} lv.");
            Console.WriteLine($"Suite: {suiteApartment:f2} lv.");



        }
    }
    class Hotel
    {
        public string Month { get; set; }
        public int Studio { get; set; }
        public int Double { get; set; }
        public int Suite { get; set; }
    }
}