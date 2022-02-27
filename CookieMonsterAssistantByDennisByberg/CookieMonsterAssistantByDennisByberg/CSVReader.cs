using CookieMonsterAssistantByDennisByberg_Ingredient;
using CookieMonsterAssistantByDennisByberg_Recipe;

namespace CookieMonsterAssistantByDennisByberg_CSVReader
{
    internal static class CSVReader
    {
        internal static Recipe BigAndButteryChocolateChipCookiesRecipe()
        {
            Console.Clear();

            var lines = File.ReadAllLines("BigAndButteryChocolateChipCookiesRecipe.csv");
            var startIngredients = Array.FindIndex(lines, x => x == "Ingredients:");
            var stopIngredients = Array.FindIndex(lines, x => x == "Directions:");

            var ingredients = new List<Ingredient>();

            for (int i = startIngredients + 1; i < stopIngredients; i++)
                ingredients.Add(new Ingredient(lines[i]));

            var recept = new Recipe
            {
                Text = lines.Take(startIngredients + 1).ToArray(),
                Ingredients = ingredients.ToArray(),
                Directions = lines.Skip(stopIngredients).ToArray()
            };

            return recept;
        }

        internal static Recipe BakedRicottaCakeRecipe()
        {
            Console.Clear();

            var lines = File.ReadAllLines("BakedRicottaCake.csv");
            var startIngredients = Array.FindIndex(lines, x => x == "Ingredients:");
            var stopIngredients = Array.FindIndex(lines, x => x == "Directions:");

            var ingredients = new List<Ingredient>();

            for (int i = startIngredients + 1; i < stopIngredients; i++)
                ingredients.Add(new Ingredient(lines[i]));

            var recept = new Recipe
            {
                Text = lines.Take(startIngredients + 1).ToArray(),
                Ingredients = ingredients.ToArray(),
                Directions = lines.Skip(stopIngredients).ToArray()
            };

            return recept;
        }
    }
}