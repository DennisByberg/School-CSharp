using CookieMonsterAssistantByDennisByberg;

namespace CookieMonsterAssistantByDennisByberg_Ingredient
{
    internal class Ingredient
    {
        public Ingredient(string line)
        {
            var values = line.Split(',');
            Amount = FractionToDouble(values[0].Trim());
            Measure = values[1].Trim();
            Product = values[2].Trim();

            if (values.Length > 3)
            {
                Description = values[3].Trim();
            }
            ConvertToSwedish();
        }

        internal double Amount { get; set; }
        internal string Measure { get; set; }
        internal string Product { get; set; }
        internal string? Description { get; set; }

        public void Multiply(int multiplier)
        {
            Amount *= multiplier;
        }

        public override string ToString()
        {
            var amount = Amount;
            Amount = Math.Round(amount, 1);

            if (Description == null)
                return $"{Amount} {Measure}, {Product}";
            else
                return $"{Amount} {Measure}, {Product}, {Description}";
        }

        private void ConvertToSwedish()
        {
            Amount = SwedishConverter.ConvertToSwedishAmount(Amount, Measure);
            Measure = SwedishConverter.ConvertToSwedishMeasure(Measure);
        }

        // https://stackoverflow.com/questions/13903621/convert-a-text-fraction-to-a-decimal
        private static double FractionToDouble(string fraction)
        {
            if (double.TryParse(fraction, out double result))
            {
                return result;
            }

            string[] split = fraction.Split(new char[] { ' ', '/' });

            if (split.Length == 2 || split.Length == 3)
            {
                if (int.TryParse(split[0], out int a) && int.TryParse(split[1], out int b))
                {
                    if (split.Length == 2)
                    {
                        return (double)a / b;
                    }
                    if (int.TryParse(split[2], out int c))
                    {
                        return a + ((double)b / c);
                    }
                }
            }
            throw new FormatException("Not a valid fraction.");
        }
    }
}