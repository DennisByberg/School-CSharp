namespace Övning4
{
    static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.CursorVisible = false;

            int[] myArray = { 1, 2, 3 };
            Console.WriteLine(ArraySum(myArray));
        }

        // Byt gärna startIndex
        public static int ArraySum(int[] array, int startIndex = 0)
        {
            // BASFALL.
            if (array[startIndex] == array[^1]) // ^1 = array.length - 1
            {
                return array[^1]; // ^1 = array.length - 1
            }

            // REKURSIONSFALL.
            return array[startIndex] + ArraySum(array, startIndex + 1);
        }
    }
} 