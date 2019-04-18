using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] commandTokens = Console.ReadLine().Split(' ');
            while(commandTokens[0] != "print")
            {
                //List<string> commandTokens = command.Split(' ').ToList();
                string currentCommand = commandTokens[0];
                if(currentCommand == "add")
                {
                    int index = int.Parse(commandTokens[1]);
                    int value = int.Parse(commandTokens[2]);
                    data.Insert(index, value);
                }
                else if(currentCommand == "addMany")
                {
                    int index = int.Parse(commandTokens[1]);
                    for (int curr = 2; curr < commandTokens.Length; curr++)
                    {
                        data.Insert(index, int.Parse(commandTokens[curr]));
                        index++;
                    }
                }
                else if(currentCommand == "contains")
                {
                    int value = int.Parse(commandTokens[1]);
                    if (data.Contains(value))
                    {
                        Console.WriteLine(data.IndexOf(value));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if(currentCommand == "remove")
                {
                    int index = int.Parse(commandTokens[1]);
                    data.RemoveAt(index);
                }
                else if(currentCommand == "shift")
                {
                    int shiftRotations = int.Parse(commandTokens[1]);
                    for (int currentRotation = 0; currentRotation < shiftRotations; currentRotation++)
                    {
                        int tempFirstElementValue = data[0];
                        for (int index = 0; index < data.Count - 1; index++)
                        {
                            data[index] = data[index + 1];
                        }
                        data[data.Count - 1] = tempFirstElementValue;
                    }
                }
                else
                {
                    for (int index = 0; index < data.Count - 1; index++)
                    {
                        data[index] += data[index + 1];
                        data.RemoveAt(index + 1);
                    }
                }
                commandTokens = Console.ReadLine().Split(' ');
            }
            Console.WriteLine($"[{string.Join(", ", data)}]");
        }
    }
}
