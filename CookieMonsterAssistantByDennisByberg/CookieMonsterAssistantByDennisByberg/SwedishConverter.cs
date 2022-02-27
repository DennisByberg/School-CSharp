namespace CookieMonsterAssistantByDennisByberg
{
    internal static class SwedishConverter
    {
        internal static double ConvertToSwedishAmount(double amount, string measure)
        {
            if (measure == "cup" || measure == "cups")
            {
                return amount * 2.25;
            }

            else if (measure == "teaspoon" || measure == "teaspoons")
            {
                return amount * 5;
            }
            return amount;
        }

        internal static string ConvertToSwedishMeasure(string measure)
        {
            if ( measure == "cup" || measure == "cups")
            {
                return "dl";
            }

            else if (measure == "teaspoon" || measure == "teaspoons")
            {
                return "ml";
            }

            return measure;
        }
    }
}
