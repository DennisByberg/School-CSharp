using System;

namespace Tågresa
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime idag = DateTime.Now;
            int startTimme = 8;
            int startMinut = 24;
            int frammeTimme = 11;
            int frammeMinut = 33;

            DateTime start = new DateTime(idag.Year, idag.Month, idag.Day, startTimme, startMinut, 00);
            DateTime framme = new DateTime(idag.Year, idag.Month, idag.Day, frammeTimme, frammeMinut, 00);
            TimeSpan resTid = framme - start;
            // Skriv ut resultatet
            Console.WriteLine($"Resan tar {resTid.Hours:00}:{resTid.Minutes:00}");

        }
    }
}
