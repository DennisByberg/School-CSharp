using CookieMonsterAssistantByDennisByberg.Menus;

namespace ProgramNS
{
    internal static class Program
    {
        internal static void Main()
        {
            Console.CursorVisible = false; // <~ Väldigt snyggt att slippa se cursor under programmets gång :) ...
            var text = new Text();         // <~ Tråkig instans av Text() ... 
            text.HomeMenu();               // <~ Startar upp projektet ...
        }
    }
}