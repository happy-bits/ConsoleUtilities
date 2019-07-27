using ConsoleUtilities;
using ConsoleUtilities.PageMenus;
using PageApp.Pages;

namespace PageApp
{
    class Program
    {
        static ConsoleCompanion cc = new ConsoleCompanion();

        static void Main()
        {
            cc.FullScreen();
            Page.Start(new MainMenuPage());
        }
    }
}
