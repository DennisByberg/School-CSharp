using CookieMonsterAssistantByDennisByberg.Menus;

namespace ProgramNS
{
    internal static class Program
    {
        internal static void Main()
        {
            Console.CursorVisible = false;
            var text = new Text();

            text.HomeMenu();
        }
    }
}