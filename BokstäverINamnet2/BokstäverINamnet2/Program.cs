using System;

namespace BokstäverINamnet2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Användaren matar in sitt förnamn och vi sparar den i variabeln "förNamn"
            Console.Write("Ange ditt förnamn: ");
            string förNamn = Console.ReadLine();

            // Användaren matar in sitt efternamn och vi sparar den i variabeln "efterNamn"
            Console.Write("Ange ditt efternamn: ");
            string efterNamn = Console.ReadLine();

            // Lägger ihop svaren.
            string helaNamnet = förNamn + efterNamn;

            // Skriver ut i konsollen antalet bokstäver i ditt förnamn, efternamn och hela ditt namn.
            Console.WriteLine($"Ditt förnamn har {förNamn.Length} antal bokstäver i sig.");
            Console.WriteLine($"Ditt efternamn har {efterNamn.Length} antal bokstäver i sig.");
            Console.WriteLine($"Hela ditt namn har {helaNamnet.Length} antal bokstäver i sig.");
        }
    }
}
