using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3
{
    public class TextAndStory
    {
        public static void GameName()
        {
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|                               |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|         DUNGEON ESCAPE        |");
            Console.WriteLine("|             v 1.4             |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|                               |");
            Console.WriteLine("+-------------------------------+");
        }

        public static void IntroText()
        {
            // Username Check.
            Console.Write("Enter your username: ");
            Program.player1.name = Console.ReadLine();

            // Age Check.
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.Clear();
                TextAndStory.Print("Sorry, you are to young to play this game, come back when you are 18. ");
                System.Threading.Thread.Sleep(500);
                System.Environment.Exit(0);
            }

            Console.Clear();

            // Story Text (#1)
            Print("Welcome to Dungeon Escape 1.4!");
            System.Threading.Thread.Sleep(500);
            Print("Your goal is to get to the 10th dungeon where there is a door to set you free.\nTo get there you need to fight a coulpe of monsters so you can advance.");
            // If you write a blanc space in your name input, this will print that you dont even remember your name. else it will print your name.
            if (Program.player1.name == "")
            {
                System.Threading.Thread.Sleep(500);
                TextAndStory.Print("\nYou cant even remember your own name.");
            }
            else
            {
                System.Threading.Thread.Sleep(500);
                Print($"\nAlright... Lets get started {Program.player1.name}...");
            }

            PressEnter();
            Console.ReadKey();
            Console.Clear();


            Print("You grope around in the darkness until you find a door handle. You feel some resistance as");
            Print("you turn the handle, but the rusty lock breaks with little effort");
            PressEnter();
            Console.ReadKey();
        }

        // This is a cool print method! TextAndStory.Print("Your Text") to use.
        public static void Print(string text, int speed = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

        public static void BattlePrint(string text, int speed = 15)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

        public static void PressEnter()
        {
            System.Threading.Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Print("\nPress <ENTER> to continue...");
            Console.ResetColor();
        }
        public static void VictoryScreen()
        {
            Console.Clear();
            Print("You succesfully escaped the dungeon, you are free!!!!");
            Print("\nCongrats, you won the game!");
            Console.WriteLine("Press <ENTER> to quit the game");
            Console.ReadKey();
            System.Environment.Exit(0);
        }

    }
}
