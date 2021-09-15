using System;

namespace Triangel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabler
            int sidaA = 0;
            int sidaB = 0;
            int sidaC = 0;

            // Användaren anger längden på sidorna av triangeln
            Console.Write("Ange längden på sida A: ");
            sidaA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ange längden på sida B: ");
            sidaB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ange längden på sida C: ");
            sidaC = Convert.ToInt32(Console.ReadLine());

            // Uträkning på omkrets och area av en triangel
            int omkrets = (sidaA + sidaB + sidaC);
            int area = (sidaA * sidaB);

            // Ger svar i consollen
            Console.WriteLine("\nOmkretsen på den angivna triangeln är: " + omkrets + "cm");
            Console.WriteLine("Arean på den angivna triangeln är: " + area + "cm");
        }
    }
}
