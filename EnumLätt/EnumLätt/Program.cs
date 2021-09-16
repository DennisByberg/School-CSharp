using EnumLätt.Veckodagar;
using System;

namespace EnumLätt
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Ange ett nummer mellan 1-7");
            string input = Console.ReadLine();
            int.TryParse(input, out int day);

            Console.WriteLine((VeckoDagar)day);
        }
    }
}
