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

            Console.WriteLine($"De delar så att de får en krona var");
            kalle++;
            pelle++;
            tjalle++;
            kvarEfterKöp -= 3;
            rödaKorset += kvarEfterKöp;
            Console.WriteLine($"Kalle har nu {kalle}");
            Console.WriteLine($"Pelle har nu {pelle}");
            Console.WriteLine($"Tjalle har nu {tjalle}");
            Console.WriteLine($"Och donerar {kvarEfterKöp} till Röda korset");
            kvarEfterKöp = 0;
            Console.WriteLine();

            Console.WriteLine($"Summa summarum:");

            //int utlägg = (10 - 1) * 3; // Gammal kod
            int utlägg = 9 * 3; // Ny Kod

            //Console.WriteLine($"De betalade 10 - 1 kronor var, alltså 9*3 = {utlägg} kronor");
            Console.WriteLine($"De betalade 9 kronor var, alltså 9*3 = {utlägg} kronor (inkl dricks)"); // Ny Kod

            //Console.WriteLine($"och donerade 2 kronor"); // Gammal Kod
            Console.WriteLine($"Dom får tillbaks 1kr var"); // Ny Kod

            //utlägg += 2; // Gammal Kod
            utlägg += 3; // Ny Kod

            Console.WriteLine($"Summan blir då: {utlägg}");
            //if (utlägg != 30) Console.WriteLine($"Error 404: Krona not found");




            Console.ReadLine();
        }
    }
}
