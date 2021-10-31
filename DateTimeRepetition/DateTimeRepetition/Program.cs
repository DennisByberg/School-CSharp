using System;

namespace DateTimeRepetition
{
    class Program
    {
        public static void TodaysDate()
        {
            // VARIABLER.
            var today = DateTime.Now;

            // KOD.
            Console.Write("Dagens datum är: ");
            Console.WriteLine(today.ToString("dd MMMM yyyy"));

        }

        public static void DateInOneWeek()
        {
            // VARIABLER.
            var nextWeek = DateTime.Now.AddDays(7);

            // KOD.
            Console.Write("Om exakt en vecka är datumet: ");
            Console.WriteLine(nextWeek.ToString("dd MMMM yyyy"));

        }

        public static void HalloweenWeekday()
        {
            // VARIABLER.
            var halloween = new DateTime(DateTime.Now.Year, 10, 31).DayOfWeek;

            // KOD.
            Console.WriteLine($"I år är Halloween på en: {halloween}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            // Skriver ut dagens datum.
            TodaysDate();
            Console.WriteLine("---------------------------------------------");
            // Skriver ut vilket datum det är om en vecka.
            DateInOneWeek();
            Console.WriteLine("---------------------------------------------");
            // Skriver ut vilken dag det är halloween
            HalloweenWeekday();
            Console.WriteLine("---------------------------------------------");

            // THE END.
            Console.WriteLine("\nTryck på <ENTER> för att avlsuta.");
            Console.ReadLine();
        }
    }
}
