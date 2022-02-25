using CookieMonsterAssistantByDennisByberg.Menus;

internal class Program
{
    internal static void Main()
    {
        Console.CursorVisible = false;
        var menu = new Menu();

        menu.HomeMenu();
    }
}