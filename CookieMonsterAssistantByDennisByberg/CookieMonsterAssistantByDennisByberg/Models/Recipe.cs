using CookieMonsterAssistantByDennisByberg.Menus;
using CookieMonsterAssistantByDennisByberg_Ingredient;

namespace CookieMonsterAssistantByDennisByberg_Recipe
{
    internal class Recipe
    {
        internal string[] Text { get; set; } = null!;
        internal Ingredient[] Ingredients { get; set; } = null!;
        internal string[] Directions { get; set; } = null!;

        public void Print()
        {
            foreach (var txt in Text)
                Console.WriteLine(txt);

            foreach (var ingredient in Ingredients)
                Console.WriteLine(ingredient);

            Console.WriteLine(); // <~ Ny Rad...

            foreach (var direction in Directions)
                Console.WriteLine(direction);

            Console.WriteLine("\n(G)o Back ( alt. press <Backspace> )");
            var choice = Console.ReadKey();
            var text = new Text();
            if (choice.Key == ConsoleKey.G || choice.Key == ConsoleKey.Backspace)
            {
                Console.Clear();
                text.RecepiesMenu();
            }
            else
            {
                Console.Clear();
                Print();
            }
        }

        public void MultipliRecpie(int multiplier)
        {
            foreach (var ingredient in Ingredients)
                ingredient.Multiply(multiplier);
        }
    }
}
