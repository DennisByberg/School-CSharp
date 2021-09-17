using System;
using System.Threading;

namespace Oh_Fortuna
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabler.
            int userPix = 500; // Antal Pix du startar med.
            int bet = 0;
            int number = 0;
            int diceAmount = 3; // Antal tärningar du kastar.
            int sameNumber = 0;

            int[] randomNumber = new int[diceAmount];
            Random rnd = new Random();

            // Välkommen.
            Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine("| WELCOME TO OH FORTUNA MADE MY DENNIS BYBERG |");
            Console.WriteLine("+---------------------------------------------+");

            // Ange ditt användarnamn för ett mer personligt spelande.
            Console.Write("Please choose your username: ");
            string userName = Console.ReadLine();
            Console.Clear();
            Console.Write($"Hi {userName}! Lets get started!\n\nLoading.");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Console.Clear();

            
            while (userPix >= 50)
            {
                // Anger hur mycket vi vill betta.
                if (bet == 0)
                {
                    Console.WriteLine($"How many Pix do you want to bet? | Pix Available: {userPix} |");
                    int.TryParse(Console.ReadLine(), out bet);
                }

                if (bet > userPix)
                {
                    Console.WriteLine("You don't have enough Pix.");
                    bet = 0;
                    continue;
                }

                if (bet < 50)
                {
                    Console.WriteLine("You must bet atleast 50 Pix");
                    bet = 0;
                    continue;
                }

                // Ange ditt nummer du vill spela på.
                Console.WriteLine("\nPick your lucky number between (1-6)?");
                int.TryParse(Console.ReadLine(), out number);

                if (number > 6 || number < 1)
                {
                    Console.WriteLine("Invalid Answer!");
                    continue;
                }

                Console.Write("\nThrowing dices.");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".\n");

                userPix -= bet;

                // Tärningar kastas och slumpas.
                for (int i = 0; i < diceAmount; ++i)
                {
                    randomNumber[i] = rnd.Next(1, 7);
                    Console.WriteLine("+--------------+");
                    Console.WriteLine("|Tärning #{0}: {1} |", i + 1, randomNumber[i]);
                    Console.WriteLine("+--------------+");

                    if (randomNumber[i] == number)
                    {
                        sameNumber++;
                    }
                }

                // Skriver ut till konsollen om vi har RÄTT.
                if (sameNumber > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nice throw " + userName + "!\nYou got {0} correct guess(es)! You win {1} pix!", sameNumber, (sameNumber + 1) * bet);
                    userPix += (sameNumber + 1) * bet;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // Skriver ut till konsollen om vi har FEL. 
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry " + userName + "!\nNo correct guesses this time!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine($"\n| Pix Available: {userPix} |");

                sameNumber = 0;
                bet = 0;

                // Frågar om vi vill spela igen
                if (userPix > 50)
                {
                    Console.WriteLine("Do you want to play again? (y/n)");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (userAnswer == "n")
                    {
                        Console.WriteLine($"Thanks for playing {userName}!");
                        Thread.Sleep(2000);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Answer! (y/n)?");
                        userAnswer = Console.ReadLine();
                        Console.Clear();
                    }

                    // Om vi får mindre än 50 Pix kan vi inte spela igen... Hejdå.
                    if (userPix < 50)
                    {
                        Console.WriteLine($"Sorry {userName}! You dont have enough Pix to play!\nThanks for playing!");
                        Thread.Sleep(2000);
                        break;
                    }
                }
            }
        }
    }
}