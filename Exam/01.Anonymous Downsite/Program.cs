namespace _01.Anonymous_Downsite
{
    using System;
    using System.Numerics;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
            string pattern = @"[^\s]+";
            Regex regex = new Regex(pattern);

            int numberOfWebsites = int.Parse(Console.ReadLine());
            int securityToken = int.Parse(Console.ReadLine());


            decimal totalLoses = 0;
            for (int curr = 0; curr < numberOfWebsites; curr++)
            {
                string[] inputArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string websiteName = inputArgs[0];
                uint siteVisits = uint.Parse(inputArgs[1]);
                decimal commercialPricePerVisit = decimal.Parse(inputArgs[2]);
                Match match = regex.Match(websiteName);

                if (match.Success)
                {
                    Console.WriteLine(websiteName);
                    totalLoses += ((decimal)siteVisits * commercialPricePerVisit);
                }
            }
            BigInteger securityTokenV = securityToken;
            for (int index = 1; index < numberOfWebsites; index++)
            {
                securityTokenV *= securityToken;
            }
            Console.WriteLine($"Total Loss: {totalLoses:f20}");
            Console.WriteLine($"Security Token: {securityTokenV}");
        }
    }
}
