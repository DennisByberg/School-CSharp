namespace Övning5
{
    public static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.CursorVisible = false;
            Console.WriteLine(Fibonacci(5));
        }

        private static int Fibonacci(int n)
        {
            // BASFALL 1 & 2.
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            // REKURSIONSFALL | Vi Anropar Metoden Igen.
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}