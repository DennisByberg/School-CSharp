using System;

namespace EnumSvår
{
    class Program
    {
        private static string dayname;

        static void Main(string[] args)
        {

            Console.WriteLine("Ange en dag");
            string input = Console.ReadLine();
            int.TryParse(input, out int day);

            input = input.ToLower(); // Gör allt till gemener
            string dayName = input.Substring(0, 1); // kopiera första bokstaven
            dayName = dayName.ToUpper(); // Gör den nya variabeln VERSAL
            dayName += input.Substring(1); // kopiera resten av input

            object? objThing = null; // Skapa en behållare
            Enum.TryParse(typeof(Veckodagar), dayname, out objThing); // omvandla text till object
            Veckodagar miniX = (Veckodagar)objThing; // Omvandla Object till text

            Console.WriteLine((Veckodagar)day);
        }
    }
}
