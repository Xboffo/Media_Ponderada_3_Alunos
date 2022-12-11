using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, media;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((a * 2) + (b * 3) + (c * 5)) / (2 + 3 + 5);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));







        }
    }
}