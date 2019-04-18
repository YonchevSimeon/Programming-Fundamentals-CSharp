namespace _02.AnonymousThreat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList(); ;
            string inputArgs;
            while ((inputArgs = Console.ReadLine()) != "3:1")
            {
                string[] inputCommand = inputArgs.Split(' ');
                string command = inputCommand[0];
                int startIndex = int.Parse(inputCommand[1]);
                int endIndex = int.Parse(inputCommand[2]);

                if (command == "merge")
                {
                    if (startIndex < 0 || startIndex >= input.Count)
                        startIndex = 0;
                    if (endIndex >= input.Count)
                        endIndex = input.Count - 1;
                    if (startIndex > endIndex)
                        continue;
                    string tempString = string.Empty;
                    for (int index = startIndex; index <= endIndex; index++)
                    {
                        tempString += input[index];
                        input[index] = "";
                    }
                    input.Insert(startIndex, tempString);
                    input.RemoveAll(x => x == "");
                }
                else if (command == "divide")
                {
                    int currentIndexOgValue = input[startIndex].Length;
                    string currentIndexValue = input[startIndex];
                    input.RemoveAt(startIndex);
                    int countOfPortions = currentIndexValue.Length / endIndex;
                    int currentIndex = startIndex;
                    int currentIndexToSubstring = 0;

                    if (currentIndexValue.Length % endIndex == 0)
                    {

                        for (int index = 0; index < endIndex; index++)
                        {
                            input.Insert(currentIndex, currentIndexValue.Substring(currentIndexToSubstring, countOfPortions));
                            currentIndexToSubstring += countOfPortions;
                            currentIndex++;
                        }
                    }
                    else if (currentIndexValue.Length % endIndex != 0)
                    {

                        for (int index = 1; index <= endIndex; index++)
                        {
                            if (index == endIndex)
                            {
                                countOfPortions = currentIndexOgValue - currentIndexToSubstring;
                            }

                            input.Insert(currentIndex, currentIndexValue.Substring(currentIndexToSubstring, countOfPortions));
                            currentIndexToSubstring += countOfPortions;
                            currentIndex++;
                        }
                    }

                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
