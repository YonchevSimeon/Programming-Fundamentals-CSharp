using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            //(sbyte < byte < short < ushort < int < uint < long)
            Dictionary<string, bool> data = new Dictionary<string, bool>();
            
            string input = Console.ReadLine();

            sbyte sbyteNumber = 0;
            bool sbyteChecker = sbyte.TryParse(input, out sbyteNumber);
            data["* sbyte"] = sbyteChecker;
            byte byteNumber = 0;
            bool byteChecker = byte.TryParse(input, out byteNumber);
            data["* byte"] = byteChecker;
            short shortNumber = 0;
            bool shortChecker = short.TryParse(input, out shortNumber);
            data["* short"] = shortChecker;
            ushort ushortNumber = 0;
            bool ushortChecker = ushort.TryParse(input, out ushortNumber);
            data["* ushort"] = ushortChecker;
            int intNumber = 0;
            bool intChecker = int.TryParse(input, out intNumber);
            data["* int"] = intChecker;
            uint uintNumber = 0;
            bool uintChecker = uint.TryParse(input, out uintNumber);
            data["* uint"] = uintChecker;
            long longNumber = 0;
            bool longChecker = long.TryParse(input, out longNumber);
            data["* long"] = longChecker;

            if (!longChecker)
            {
                Console.WriteLine($"{input} can't fit in any type");
                return;
            }
            Console.WriteLine($"{input} can fit in:");
            foreach (KeyValuePair<string, bool> dataType in data)
            {
                if(dataType.Value == true)
                {
                    Console.WriteLine(dataType.Key);
                }
            }
        }
    }
}
