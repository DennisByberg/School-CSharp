namespace Övning6
{
    public static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.CursorVisible = false;
            PrintEven(9, 21);
        }

        public static void PrintEven(int min, int max)
        {
            // BASFALL.
            if (min == max)
            {
                if (min % 2 == 0)
                {
                    Console.WriteLine(min);
                    Thread.Sleep(2000);
                    return;
                }

                Thread.Sleep(2000);
                return;
            }

            if (min % 2 == 0)
            {
                Console.WriteLine(min);
                Thread.Sleep(200);
            }

            PrintEven(min + 1, max); // REKURSIONSFALL
        }
    }
}
