using System;

namespace HundOchKattÅr
{
    class Program
    {
        static void Main(string[] args)
        {
            int HumanAge;
            int DogAge;

            Console.Write("Hur gammal är du?: ");
            HumanAge = Convert.ToInt32(Console.ReadLine());

            DogAge = (HumanAge * 7);

            Console.WriteLine($"Du är {HumanAge} år och i Hund/Kattår är du {DogAge}");
        }
    }
}
