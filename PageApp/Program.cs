using ConsoleUtilities;
using PageApp.Pages;

namespace PageApp
{
    class Program
    {
        static ConsoleCompanion cc = new ConsoleCompanion();

        static void Main()
        {
            cc.FullScreen();

            new MainMenuPage().Execute(); ;
        }
    }
}
