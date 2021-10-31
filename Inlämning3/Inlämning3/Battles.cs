using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3
{
    public class Battles
    {
        static Random rnd = new Random();

        public static void FirstBattle()
        {
            Console.Clear();
            TextAndStory.Print("You throw open the door, and grab a rusty metal sword.");
            TextAndStory.PressEnter();
            Console.ReadKey();
            BasicFightBattle();
        }
        public static void BasicFightBattle()
        {
            Console.Clear();
            Console.WriteLine("You search throught the room for enemies...");
            TextAndStory.PressEnter();
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }

        public static void RandomBattle()
        {
            switch (rnd.Next(0, 1))
            {
                case 0:
                    BasicFightBattle(); break;
            }
        }


        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;

            if (random)
            {
                n = GetName();
                p = Program.player1.GetPower();
                h = Program.player1.GetHealth();
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }

            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine($"+=======================+");
                Console.WriteLine($"|       {n}       |");
                Console.WriteLine($"+=======================+");
                Console.WriteLine($"  lvl: {p}  |  health: {h} ");
                Console.WriteLine($"+-----------------------+");
                // This is the menu of options you have in the battle.
                Console.WriteLine("\n+========================+");
                Console.WriteLine("| (A)ttack               |");
                Console.WriteLine("| (H)eal                 |");
                Console.WriteLine("| (R)un                  |");
                Console.WriteLine("+========================+");

                // This shows how many potions and health you have at the moment.
                Console.WriteLine($" Potions: {Program.player1.potion} Health: {Program.player1.health}");

                string input = Console.ReadLine();

                /*------------------- [ ATTACK ] -----------------*/
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    TextAndStory.BattlePrint($"You swing your sword...");
                    System.Threading.Thread.Sleep(300);
                    int damage = p - Program.player1.armor;

                    if (damage < 0)
                    {
                        damage = 0;
                    }

                    int attack = rnd.Next(0, Program.player1.weapon) + rnd.Next(1, 4);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    TextAndStory.BattlePrint($"\nYou deal {attack} hp.");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(600);
                    Console.ForegroundColor = ConsoleColor.Red;
                    TextAndStory.BattlePrint($"{n} Strikes back and deal {damage} hp.");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(1100);
                    Program.player1.health -= damage;
                    h -= attack;
                    continue;
                }

                /*-------------------- [ RUN ] ------------------*/
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    if (rnd.Next(0, 2) == 0)
                    {
                        Console.WriteLine($"As you sprint away from the {n} its strike catches you in the back, sending you to the ground.");
                        int damage = p - Program.player1.armor;
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        Console.WriteLine($"You lose {damage} health and are unable to escape this time.");
                        Program.player1.health -= damage;
                    }
                    else
                    {
                        Console.WriteLine($"You succesfully ran away from {n}...");
                        Console.ReadKey();
                        Shop.LoadShop(Program.player1);
                    }
                }

                /*-------------------- [ HEAL ] ------------------*/
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    if (Program.player1.potion == 0)
                    {
                        Console.WriteLine("You have no potions left.");
                        int damage = p - Program.player1.armor;
                        {
                            damage = 0;
                        }
                        Console.WriteLine($"The {n} strikes you with a mighty blow and you lose {damage} health");
                    }
                    else
                    {
                        Console.WriteLine("You reach into your bag and drink the potion.");
                        int potionV = 5;
                        Console.WriteLine($"You gain {potionV} health.");
                        Program.player1.health += potionV;
                        Program.player1.potion--;
                    }
                }

                // This shows when/if you die.
                if (Program.player1.health <= 0)
                {
                    TextAndStory.Print($"As the {n} stands tall and comes down to strike. You have been slayn by the mighty {n}!\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    TextAndStory.Print($"YOU LOSE!");
                    Console.ResetColor();
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }

            // This shows how much coins and exp the enemy is going to drop.
            int c = Program.player1.GetCoins();
            int x = Program.player1.GetXP();
            Console.Clear();
            TextAndStory.Print($"You defeated {n}!");
            Console.ForegroundColor = ConsoleColor.Green;
            TextAndStory.Print($"+{c} COINS \n+{x} EXP");
            Console.ResetColor();
            Program.player1.coins += c;
            Program.player1.xp += x;

            if (Program.player1.CanLevelUp())
            {
                Program.player1.LevelUp();
            }
            TextAndStory.PressEnter();
            Console.ReadKey();
        }

        // Enemy Randomizer.
        public static string GetName()
        {
            switch (rnd.Next(0, 4))
            {
                case 0:
                    return "Big Troll";
                case 1:
                    return "Giant Rat";
                case 2:
                    return "Super Cow";
                case 3:
                    return "Hobgoblin";
            }
            return "Magic Elf";
        }
    }
}
