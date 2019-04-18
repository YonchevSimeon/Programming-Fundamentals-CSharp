namespace _03.AnonymousVox
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            MatchCollection matches = Regex.Matches(encodedText, @"([A-Za-z]+)(.+)(\1).*?");
            string[] values = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            int valueIndex = 0;
            foreach (Match match in matches)
            {
                if (valueIndex >= values.Length)
                    break;
                int startIndex = encodedText.IndexOf(match.Groups[2].Value);
                int length = match.Groups[2].Length;
                string firstPart = encodedText.Substring(0, startIndex);
                string lastPart = encodedText.Substring(startIndex + length, encodedText.Length - (startIndex + length));
                encodedText = firstPart + values[valueIndex] + lastPart;
                valueIndex++;
            }
            Console.WriteLine(encodedText);
        }
    }
}
