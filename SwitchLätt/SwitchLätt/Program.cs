using System;

namespace SwitchLätt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ber användaren mata in ett tal mellan 1 till 50
            Console.Write("Ange ett tal mellan 1 och 50: ");

            // Omvandlar till int
            string input = Console.ReadLine();
            int.TryParse(input, out int tal);

            string resultat = string.Empty;

            // Våran eleganta switch :)
            switch (tal)
            {
                case 11: resultat = "11"; break;
                case 22: resultat = "22"; break;
                case 33: resultat = "33"; break;
                case 44: resultat = "44"; break;
                case < 1: resultat = "För litet"; break;
                case < 10: resultat = "mindre än 10"; break;
                case < 20: resultat = "mindre än 20"; break;
                case < 30: resultat = "mindre än 30"; break;
                case < 40: resultat = "mindre än 40"; break;
                case > 50: resultat = "Aldelles för högt"; break;
            }

            // Skriver ut talet i konsollen
            Console.WriteLine($"Talet är {resultat}");
        }
    }
}

