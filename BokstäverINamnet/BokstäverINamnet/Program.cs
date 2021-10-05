using System;

namespace BokstäverINamnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();

            Console.WriteLine("Ditt namn är " + namn.Length +" bokstäver långt!");
        }
    }
}
