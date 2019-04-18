using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputTokens = input.ToCharArray();
            char preLastChar = inputTokens[inputTokens.Length - 2];
            char lastChar = inputTokens[inputTokens.Length - 1];
            if(lastChar == 'y')
            {
                input = input.Remove(input.Length - 1, 1);
                input += "ies";
            }
            else if(lastChar == 'o' || lastChar == 's' || lastChar == 'x' ||  lastChar == 'z' ||
                    (preLastChar == 'c' && lastChar == 'h') || (preLastChar == 's' && lastChar == 'h'))
            {
                input += "es";
            }
            else
            {
                input += "s";
            }
            Console.WriteLine(input);
        }
    }
}
