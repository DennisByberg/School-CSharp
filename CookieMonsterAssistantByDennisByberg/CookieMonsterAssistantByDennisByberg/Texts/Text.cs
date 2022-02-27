using CookieMonsterAssistantByDennisByberg_CSVReader;

namespace CookieMonsterAssistantByDennisByberg.Menus
{
    internal class Text
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
            Console.WriteLine("┌───────────────────────────────────────────────┐");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                   Recepies                    │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("└───────────────────────────────────────────────┘");

            Console.WriteLine("(B)ig & Buttery Chocolate Chip Cookies"); // 1

            // TODO: 2a receptet...

            // TODO: 3e receptet...

            Console.WriteLine("\n(G)o Back ( alt. press <Backspace> )");

            var choice = Console.ReadKey();
            if (choice.Key == ConsoleKey.G || choice.Key == ConsoleKey.Backspace)
            {
                Console.Clear();
                HomeMenu();
            }
            else if (choice.Key == ConsoleKey.B)
            {
                Console.Clear();
                var recept1 = CSVReader.BigAndButteryChocolateChipCookiesRecipe();
                Console.Write("How many batches do you want to make?: ");
                _ = int.TryParse(Console.ReadLine(), out int batchAmount);
                recept1.MultipliRecpie(batchAmount);
                Console.WriteLine("┌───────────────────────────────────────────────┐");
                Console.WriteLine("│     Big & Buttery Chocolate Chip Cookies      │");
                Console.WriteLine("└───────────────────────────────────────────────┘");
                recept1.Print();
            }
            else
            {
                Console.Clear();
                RecepiesMenu();
            }
        }

        private static void GoodbyeMenu()
        {
            const string message ="Thank you and good bye....";
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
