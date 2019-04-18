using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SrabskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> database = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while(input != "End")
            {
                
                List<string> checkingForMinimunFourTokens = input.Split(' ').ToList();
                if (checkingForMinimunFourTokens.Count >= 4)
                {
                    List<string> checkingForDividingMonkeyA = input.Split(new string[] { " @" }, StringSplitOptions.None).ToList();
                    string singer = checkingForDividingMonkeyA[0];
                    if (!singer.Contains("@"))
                    {
                        List<string> divingOtherThreeElements = checkingForDividingMonkeyA[1].Split(' ').ToList();
                        int audience = 0;
                        bool audienceBool = int.TryParse(divingOtherThreeElements[divingOtherThreeElements.Count - 1], out audience);
                        int ticketPrice = 0;
                        bool ticketPriceBool = int.TryParse(divingOtherThreeElements[divingOtherThreeElements.Count - 2], out ticketPrice);
                        if (audienceBool && ticketPriceBool)
                        {
                            string place = string.Empty;
                            for (int index = 0; index < divingOtherThreeElements.Count - 2; index++)
                            {
                                place += $"{divingOtherThreeElements[index]} ";
                            }
                            if (!place.Contains("@"))
                            {
                                if (!database.ContainsKey(place))
                                {
                                    database[place] = new Dictionary<string, int>();
                                }
                                if (!database[place].ContainsKey(singer))
                                {
                                    database[place][singer] = 0;
                                }
                                database[place][singer] += (ticketPrice * audience);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string, Dictionary<string, int>> concert in database)
            {
                Console.WriteLine(concert.Key);
                foreach (KeyValuePair<string, int> singer in concert.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
