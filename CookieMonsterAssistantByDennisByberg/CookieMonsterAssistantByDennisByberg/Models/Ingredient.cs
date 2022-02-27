using CookieMonsterAssistantByDennisByberg;

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
        return $"{Amount}, {Measure}, {Product}, {Description}";
    }

    private void ConvertToSwedish()
    {
        Amount = SwedishConverter.ConvertToSwedishAmount(Amount, Measure);
        Measure = SwedishConverter.ConvertToSwedishMeasure(Measure);
    }

    // https://stackoverflow.com/questions/13903621/convert-a-text-fraction-to-a-decimal
    private double FractionToDouble(string fraction)
    {
        double result;

        if (double.TryParse(fraction, out result))
        {
            return result;
        }

        string[] split = fraction.Split(new char[] { ' ', '/' });

        if (split.Length == 2 || split.Length == 3)
        {
            int a, b;

            if (int.TryParse(split[0], out a) && int.TryParse(split[1], out b))
            {
                if (split.Length == 2)
                {
                    return (double)a / b;
                }

                int c;

                if (int.TryParse(split[2], out c))
                {
                    return a + (double)b / c;
                }
            }
        }

        throw new FormatException("Not a valid fraction.");
    }
}