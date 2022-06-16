namespace Övning1
{
    static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.CursorVisible = false;

            Factorial(10);
        }
        public static int Factorial(int n)
        {
            // Basfall.
            // Varför? För att här slutar alla anrop till nya metoder och vi är klara.
            if (n <= 1)
            {
                Console.WriteLine(n);
                return 1;
            }

            // Rekursionfall.
            // Varför? För att här anropar metoden sig själv.
            Console.WriteLine(n);
            return n * Factorial(n - 1);
        }
    }
}

// Summering, vad är detta? Jo en enkel for loop som räknar ner till 1...
// ... från talet vi anger i main.