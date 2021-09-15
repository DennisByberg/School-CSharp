using System;

namespace Långbord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många bord har ni??");

            int.TryParse(Console.ReadLine(), out int svar);

            Console.WriteLine(antalPlatser(svar));
        }

         static int antalPlatser(int antalBord)
        {
            int antalSidoplatser = 2;
            int antalKantplatser = 2;
            int antalSittplatser = antalBord * antalSidoplatser + antalKantplatser;
            return antalSittplatser;
        }
    }
}
