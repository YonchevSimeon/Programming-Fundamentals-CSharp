using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            List<string> inputs = new List<string>();
            string pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)(\|)";
            Regex regex = new Regex(pattern);
            //MatchCollection matches = new MatchCollection;
            string currentInputText = Console.ReadLine();
            while (currentInputText != "end")
            {
                inputs.Add(currentInputText);

                currentInputText = Console.ReadLine();
            }
            MatchCollection matches = regex.Matches(string.Join("", inputs));
            foreach (Match match in matches)
            {
                City currentCity = City.ReadCity(match.Groups[1].Value, double.Parse(match.Groups[2].Value), match.Groups[3].Value);
                City boolCity = cities.SingleOrDefault(x => x.Name == currentCity.Name);
                if (cities.Contains(boolCity))
                {
                    int index = cities.FindIndex(x => x.Name == currentCity.Name);
                    cities.RemoveAt(index);
                }
                cities.Add(currentCity);
            }
            foreach (City city in cities.OrderBy(x => x.Temperature))
            {
                Console.WriteLine($"{city.Name} => {city.Temperature:f2} => {city.Weather}");
            }
        }
    }
    class City
    {
        public string Name { get; set; }
        public double Temperature { get; set; }
        public string Weather { get; set; }
        
        public static City ReadCity(string name, double temperature, string weather)
        {
            return new City
            {
                Name = name,
                Temperature = temperature,
                Weather = weather
            };
        }
    }
}
