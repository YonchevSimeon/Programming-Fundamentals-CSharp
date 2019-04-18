using System;
using System.Collections.Generic;
using System.Linq;
public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int currentSequence = 0; currentSequence < countSequences; currentSequence++)
        {
            List<int> inputTokens = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool found = false;

            List<int> foundIntegers = new List<int>();

            for (int index = 0; index < inputTokens.Count; index++)
            {
                int currentNum = inputTokens[index];

                if (currentNum >= 0)
                {
                    foundIntegers.Add(currentNum);
                    found = true;
                }
                else if (index + 1 < inputTokens.Count)
                {
                    currentNum += inputTokens[index + 1];
                    if (currentNum >= 0)
                    {
                        foundIntegers.Add(currentNum);
                        found = true;
                    }
                    index++;
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine(string.Join(" ", foundIntegers));
            }
        }
    }
}