namespace Övning2
{
    static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.CursorVisible = false;

            var max = HowMuchDoYouWantToCountTo();
            PrintUpTo(max);
        }
        public static void PrintUpTo(int max)
        {
            // BASFALL | När max blir 0 avslutar vi att anropa metoden igen.
            if (max == 0) return;

            // REKURSIONSFALLET | Vi anropar metoden igen till vi når 0.
            PrintUpTo(max - 1);
            Console.WriteLine(max);
        }

        public static int HowMuchDoYouWantToCountTo()
        {
            Console.Write("How much do you want to count to?: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return number;
        }
    }
}