using System;

namespace Bensinkostnad
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = 344.24; // Km.
            double fuelConsumption = 6.7 / 100; // Hur mycket bilen drar per Km.
            double fuelPrice = 17.24; // Bensinpris per liter.
            double price = fuelConsumption * distance * fuelPrice; // Räknar ut vårat pris.

            // Skriver ut priset det kostar att åka från Göteborg till Rävemåla till konsollen.
            Console.WriteLine("Kostnad: " + Math.Round(price,2));
        }
    }
}
