    internal class CSVReader
    {
        internal void BigAndButteryChocolateChipCookiesRecipe()
        {
            var lines = File.ReadAllLines("BigAndButteryChocolateChipCookiesRecipe.csv");

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }