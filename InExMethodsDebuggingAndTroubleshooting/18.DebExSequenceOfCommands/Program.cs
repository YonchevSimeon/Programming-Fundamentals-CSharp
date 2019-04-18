using System;
using System.Linq;

public class SequenceOfCommands_broken
{

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();

        string input = Console.ReadLine();

        while (!input.Equals("stop"))
        {
            string[] inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (inputTokens[0] == "multiply" || inputTokens[0] == "add" || inputTokens[0] == "subtract")
            {
                string command = inputTokens[0];
                int pos = int.Parse(inputTokens[1]);
                int value = int.Parse(inputTokens[2]);
                PrintArray(PerformAction(array, command, pos, value));
            }
            else if (inputTokens[0] == "rshift")
            {
                PrintArray(ArrayShiftRight(array));
            }
            else
            {
                PrintArray(ArrayShiftLeft(array));
            }



            input = Console.ReadLine();
        }
    }

    static long[] PerformAction(long[] array, string action, int pos, int value)
    {

        switch (action)
        {
            case "multiply":
                array[pos - 1] *= value;
                break;
            case "add":
                array[pos - 1] += value;
                break;
            case "subtract":
                array[pos - 1] -= value;
                break;
        }
        return array;
    }

    private static long[] ArrayShiftRight(long[] array)
    {
        long tempLastElementValue = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = tempLastElementValue;
        return array;
    }

    private static long[] ArrayShiftLeft(long[] array)
    {
        long tempFirstElementValue = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = tempFirstElementValue;
        return array;
    }

    private static void PrintArray(long[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }
}
