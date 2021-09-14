using System;

namespace Oh_Fortuna
{
    class Program
    {
        static void Main(string[] args)
        {

            var userPix = 500;
            var bet = 0;
            var number = 0;
            var dices = 3;
            var sameNumber = 0;

            int[] slumpTal = new int[dices];
            Random rnd = new Random();


            while (userPix >= 50)
            {
                Console.WriteLine("+-----------------------------------------------+");
                Console.WriteLine("| Lets Play Oh Fortuna! du startar med 500 Pix! |");
                Console.WriteLine("+-----------------------------------------------+");

                if (bet == 0)
                {
                    Console.WriteLine("\nHur många pix vill du satsa?");
                    int.TryParse(Console.ReadLine(), out bet);
                }

                if (bet > userPix)

                {
                    Console.WriteLine("Du kan inte satsa mer än vad du har.\n");
                    bet = 0;

                    continue;
                }

                if (bet < 50)
                {
                    Console.WriteLine("Du måste minst satsa 50 kr");
                    bet = 0;

                    continue;
                }
                Console.WriteLine("Välj ditt lyckotal mellan (1-6)?");

                int.TryParse(Console.ReadLine(), out number);

                if (number > 6 || number < 1)
                {
                    Console.WriteLine("Välj ett tal mellan 1 och 6\n");

                    continue;
                }

                userPix -= bet;

                for (int i = 0; i < dices; ++i)
                {
                    slumpTal[i] = rnd.Next(1, 7);
                    Console.WriteLine("Tärning #{0}: {1}", i + 1, slumpTal[i]);

                    if (slumpTal[i] == number)
                    {
                        sameNumber++;
                    }
                }

                if (sameNumber > 0)
                {
                    Console.WriteLine("\n{0} rätt! Du vinner {1} kr", sameNumber, (sameNumber + 1) * bet);
                    userPix += (sameNumber + 1) * bet;
                }
                else
                {
                    Console.WriteLine("\nDu hade tyvärr inga rätt denna gången!\n");
                }

                Console.WriteLine("+----------------+", userPix);
                Console.WriteLine("| Antal Pix: {0} |", userPix);
                Console.WriteLine("+----------------+", userPix);

                sameNumber = 0;
                bet = 0;
            }

            if (userPix < 50)
            {
                Console.WriteLine("Du har för lite pengar tyvärr, välkommen åter!");
            }
        }
    }
}
