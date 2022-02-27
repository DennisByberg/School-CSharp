namespace CookieMonsterAssistantByDennisByberg.Models
{
    internal class Recept
    {
        internal string[] Text { get; set; }
        internal Ingredient[] Ingredients { get; set; }
        internal string[] Directions { get; set; }

        public void Print()
        {
            foreach (var text in Text)
            {
                Console.WriteLine(text);
            }

            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            foreach (var direction in Directions)
            {
                Console.WriteLine(direction);
            }
        }

        public void MultipliRecpie(int multiplier)
        {
            foreach(var ingredient in Ingredients)
            {
                ingredient.Multiply(multiplier);
            }
        }
    }
}
