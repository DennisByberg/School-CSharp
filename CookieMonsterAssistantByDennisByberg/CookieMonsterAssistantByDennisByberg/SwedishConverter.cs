namespace CookieMonsterAssistantByDennisByberg
{
    public class SwedishConverter
    {
        public double ConvertToSwedishAmount(double amount, string measure)
        {
            if (measure == "cup" || measure == "cups")
                return amount * 2.25;

            else if (measure == "teaspoon" || measure == "teaspoons")
                return amount * 4.92;

            else if (measure == "ounce" || measure == "ounces")
                return amount * 28.34;

            return amount;
        }

        public string ConvertToSwedishMeasure(string measure)
        {
            if ( measure == "cup" || measure == "cups")
                return "dl";

            else if (measure == "teaspoon" || measure == "teaspoons")
                return "ml";

            else if (measure == "ounce" || measure == "ounces")
                return "g";

            else if (measure == "piece" || measure == "pieces")
                return "st";

            return measure;
        }
    }
}