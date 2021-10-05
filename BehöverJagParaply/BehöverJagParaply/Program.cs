using System;

namespace BehöverJagParaply
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabler.
            bool rain = false;
            bool willRain = true;

            bool needUmbrella = rain || willRain;

            Console.WriteLine("Behöver jag paraply?");
            Console.WriteLine(needUmbrella);
        }
    }
}
