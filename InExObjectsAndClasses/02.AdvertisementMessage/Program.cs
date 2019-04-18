using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int numberOfInputs = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int currentSentence = 0; currentSentence < numberOfInputs; currentSentence++)
            {   
                RandomIndexes currentInput = RandomIndexes.ReadRandomIndexes(phrases, events, authors, cities, random);
                Console.WriteLine($"{phrases[currentInput.phraseIndex]} " +
                    $"{events[currentInput.eventIndex]} " +
                    $"{authors[currentInput.authorIndex]} - " +
                    $"{cities[currentInput.cityIndex]}");
            }
        }
    }
    class RandomIndexes
    {
        public int phraseIndex { get; set; }
        public int eventIndex { get; set; }
        public int authorIndex { get; set; }
        public int cityIndex { get; set; }

        public static RandomIndexes ReadRandomIndexes(string[] phrases, string[] events, string[] authors, string[] cities, Random random)
        {
            return new RandomIndexes
            {
                phraseIndex = random.Next(0, phrases.Length),
                eventIndex = random.Next(0, events.Length),
                authorIndex = random.Next(0, authors.Length),
                cityIndex = random.Next(0, cities.Length)
            };
        }
    }
}
