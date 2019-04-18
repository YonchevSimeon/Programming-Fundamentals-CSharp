using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> parsedWords = new List<string>();

            int[] skipTakeElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int skipElements = skipTakeElements[0];
            int takeElements = skipTakeElements[1];
            List<string> words = new List<string>();
            string inputText = Console.ReadLine();

            string pattern = @"\|<(\w{" + skipElements + "})(\\w{0," + takeElements + "})";
            Regex regex = new Regex(pattern);
            foreach (Match match in regex.Matches(inputText))
            {
                words.Add(match.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
