namespace Övning3
{
    static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.CursorVisible = false;

            const double balance = 1000.0;
            const int years = 10;

            CalculateBalance(balance, years);
        }

        public static double CalculateBalance(double balance, int years)
        {
            const double interestRate = 0.05;
            double interestThisYear = balance * interestRate;

            // BASFALL | När years blir 0 avslutar vi att anropa metoden igen.
            if (years == 0)
            {
                Console.WriteLine($"Balance after given years: {Math.Round(balance)}kr");
                return balance;
            }

            balance += interestThisYear;

            // REKURSIONSFALLET | Vi anropar metoden igen till vi når 0.
            CalculateBalance(balance, years - 1);

            return balance;
        }
    }
}
