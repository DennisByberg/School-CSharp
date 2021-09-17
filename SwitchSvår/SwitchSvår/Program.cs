using SwitchSvår.Enum;
using System;

namespace SwitchSvår
{
    class Program
    {
        static void Main(string[] args)
        {
            // Frågar användaren vilken månad hen vill se.
            Console.WriteLine("Vilken månad vill du se?");

            // Omvandlare
            string input = Console.ReadLine();
            int.TryParse(input, out int månad);

            object? miniOut = null;
            Enum.TryParse(typeof(BorderLimits), "minX", out miniOut); // minX
            BorderLimits miniX = (BorderLimits)miniOut; //minX

            switch (månad)
            {
                case Månader.Januari:
                    Console.WriteLine("1-Nyår");
                    break;
            }






            // SVAR
            Console.WriteLine((Månader)månad);
        }
    }
}
