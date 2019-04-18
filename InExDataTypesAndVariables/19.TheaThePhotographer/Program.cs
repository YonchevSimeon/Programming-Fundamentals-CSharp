using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long neededTimePerPicture = long.Parse(Console.ReadLine());
            long goodPicturesPercentage = long.Parse(Console.ReadLine());
            long neededTimePerUpload = long.Parse(Console.ReadLine());

            double percantage = goodPicturesPercentage / 100.0;
            double goodPictures = Math.Ceiling(numberOfPictures * percantage);

            long totalSeconds = (numberOfPictures * neededTimePerPicture) + ((long)goodPictures * neededTimePerUpload);

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            string final = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(final);
        }
    }
}
