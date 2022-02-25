// ┌ ┐ └ ┘ ─ ┤ ├ ┘ └ │ ─ • « » ●
namespace CookieMonsterAssistantByDennisByberg.Menus
{
    internal class Menu
    {
        internal void HomeMenu()
        {
            Console.WriteLine("┌───────────────────────────────────────────────┐");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│   Cookie Monster Assistant By Dennis Byberg   │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("└───────────────────────────────────────────────┘");
            Console.WriteLine("(V)iew Recepies");
            Console.WriteLine("(E)xit");

            var choice = Console.ReadKey();

            if (choice.Key == ConsoleKey.V)
            {
                Console.Clear();
                RecepiesMenu();
            }
            else if (choice.Key == ConsoleKey.E || choice.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                GoodbyeMenu();
            }
            else
            {
                Console.Clear();
                HomeMenu();
            }
        }

        internal void RecepiesMenu()
        {
            var csv = new CSVReader();

            Console.WriteLine("┌───────────────────────────────────────────────┐");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                   Recepies                    │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("└───────────────────────────────────────────────┘");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("(B)ig & Buttery Chocolate Chip Cookies"); // 1
            Console.ResetColor();

            Console.WriteLine("│2] "); // 2
            Console.WriteLine("│3] "); // 3
            Console.WriteLine("│4] "); // 4
            Console.WriteLine("│5] "); // 5
            Console.WriteLine("│6] "); // 6
            Console.WriteLine("│7] "); // 7
            Console.WriteLine("│8] "); // 8
            Console.WriteLine("\n(G)o Back"); // 9

            var choice = Console.ReadKey();

            if (choice.Key == ConsoleKey.G || choice.Key == ConsoleKey.Backspace || choice.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                HomeMenu();
            }

            else if (choice.Key == ConsoleKey.B)
            {
                csv.BigAndButteryChocolateChipCookiesRecipe();
            }

            else
            {
                Console.Clear();
                RecepiesMenu();
            }
                
        }

        private void GoodbyeMenu()
        {
            var message ="Thank you and good bye....";
            var counter = 0;
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[counter]);
                Thread.Sleep(50);
                counter++;
            }
            Thread.Sleep(1000);
        }
    }
}
