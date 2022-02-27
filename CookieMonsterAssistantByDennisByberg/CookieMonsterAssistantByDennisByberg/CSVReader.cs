using CookieMonsterAssistantByDennisByberg.Models;
using System.Collections.Generic;

internal class CSVReader
{
    internal Recipe BigAndButteryChocolateChipCookiesRecipe()
    {
        Console.Clear();

        var lines = File.ReadAllLines("BigAndButteryChocolateChipCookiesRecipe.csv");
        var startIngredients = Array.FindIndex(lines, x => x == "Ingredients:");
        var stopIngredients = Array.FindIndex(lines, x => x == "Directions:");

        var ingredients = new List<Ingredient>();

        for (int i = startIngredients +1; i < stopIngredients; i++)
        {
            ingredients.Add(new Ingredient(lines[i]));
        }

        var recept = new Recipe();
        recept.Text = lines.Take(startIngredients +1).ToArray();
        recept.Ingredients = ingredients.ToArray();
        recept.Directions = lines.Skip(stopIngredients).ToArray();

        return recept;
    }
}