using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
public class Substring_broken
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char searchedLetter = 'p';

        bool hasMatch = false;

        for (int index = 0; index < input.Length; index++)
        {
            if (input[index] == searchedLetter)
            {


                hasMatch = true;

                int endIndex = jump;

                if (endIndex + index >= input.Length)
                {
                    endIndex = input.Length - index - 1;
                }

                string matchedString = input.Substring(index, endIndex + 1);

                Console.WriteLine(matchedString);

                index += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
