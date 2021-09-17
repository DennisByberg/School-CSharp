using System;
using System.Threading;

namespace Oh_Fortuna
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabler
            int userPix = 500;
            int bet = 0;
            int number = 0;
            int dices = 3;
            int sameNumber = 0;

            int[] slumpTal = new int[dices];
            Random rnd = new Random();

            // Välkommen
            Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine("| WELCOME TO OH FORTUNA MADE MY DENNIS BYBERG |");
            Console.WriteLine("+---------------------------------------------+");

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

            // Nu kör vi!
            while (userPix >= 50)
            {

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

                for (int i = 0; i < dices; ++i)
                {
                    slumpTal[i] = rnd.Next(1, 7);
                    Console.WriteLine("+--------------+");
                    Console.WriteLine("|Tärning #{0}: {1} |", i + 1, slumpTal[i]);
                    Console.WriteLine("+--------------+");

                    if (slumpTal[i] == number)
                    {
                        sameNumber++;
                    }
                }

                if (sameNumber > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nice throw " + userName + "!\nYou got {0} correct guess(es)! You win {1} pix!", sameNumber, (sameNumber + 1) * bet);
                    userPix += (sameNumber + 1) * bet;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry " + userName + "!\nNo correct guesses this time!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine($"\n| Pix Available: {userPix} |");

                sameNumber = 0;
                bet = 0;

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

                    if (userPix < 50)
                    {
                        Console.WriteLine($"Sorry {userName}! You dont have enough Pix to play!\nThanks for playing!");
                    }

                }
            }
        }
    }
}