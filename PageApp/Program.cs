using ConsoleUtilities;
//using ConsoleUtilities.PageMenus;
//using PageApp.Pages;
using ConsoleUtilities.PageMenusInterface;
using PageApp.PagesInterface;

namespace PageApp
{
    class Program
    {
        static ConsoleCompanion cc = new ConsoleCompanion();

        static void Main()
        {
            cc.FullScreen();
            //Page.Start(new MainMenuPage());

            var x = new PageController();
            x.Start(new MainMenuPage());
        }
    }
}
