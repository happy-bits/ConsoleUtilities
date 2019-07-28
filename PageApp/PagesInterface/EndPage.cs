
using ConsoleUtilities;
using ConsoleUtilities.PageMenusInterface;

namespace PageApp.PagesInterface
{
    public class EndPage : IPage
    {
        public string Name => "End program";

        public void Run()
        {
            var cc = new ConsoleCompanion(2);
            cc.WriteLine("Thanks for using the app");
        }
    }
}
