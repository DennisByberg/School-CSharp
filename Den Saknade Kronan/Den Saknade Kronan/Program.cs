using System;

namespace Den_Saknade_Kronan
{
    class Program
    {
        static void Main(string[] args)
        {
            int bullar = 25; // pris
            int kalle = 10; // Cash
            int pelle = 10; // Cash
            int tjalle = 10;// Cash
            int rödaKorset = 0; // Donation

            Console.WriteLine($"Bullarna kostar {bullar}");
            Console.WriteLine($"Kalle har {kalle}");
            Console.WriteLine($"Pelle har {pelle}");
            Console.WriteLine($"Tjalle har {tjalle}");
            Console.WriteLine();

            Console.WriteLine($"De betalar {kalle + pelle + tjalle}");
            int kvarEfterKöp = (kalle + pelle + tjalle) - bullar;
            kalle -= 10;
            pelle -= 10;
            tjalle -= 10;
            Console.WriteLine($"Kalle har nu {kalle}");
            Console.WriteLine($"Pelle har nu {pelle}");
            Console.WriteLine($"Tjalle har nu {tjalle}");
            Console.WriteLine($"Och får tillbaka {kvarEfterKöp}");
            Console.WriteLine();
        }
    }
}
