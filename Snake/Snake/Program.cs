using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] map =
            {
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", }
            };

            int dx = 1;
            int dy = 0;

            int mx = 5;
            int my = 5;

            while (true)
            {
                Console.Clear();

                for (int y = 0; y < map.GetLength(0); y++)
                {
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        if (mx == x && my == y)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("  ");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        Console.Write(map[y, x]);
                    }

                    Console.WriteLine();
                }

                Console.ReadKey();





            }
        }
    }
}
