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
            return amount;
        }

        internal static string ConvertToSwedishMeasure(string measure)
        {
            if ( measure == "cup" || measure == "cups")
            {
                return "dl";
            }
            return measure;
        }
    }
}
