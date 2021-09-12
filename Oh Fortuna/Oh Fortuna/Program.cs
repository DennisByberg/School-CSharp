using System;

namespace Oh_Fortuna
{
    class Program
    {
        static void Main(string[] args)
        {

            var användarePix = 500;
            var användareNum = 0;


            while (användarePix >= 50)
            {
                Console.WriteLine("Lets Play Oh Fortuna! Du börjar med (500 Pix), Välj ett tal mellan 1-6");
                användareNum = int.Parse(Console.ReadLine());
            }
        }
    }
}
