using ConsoleUtilities;
using System.Threading;

namespace PageApp.Pages
{
    public class EndPage : Page
    {
        public override string Name => "End program";

        public override void Run()
        {
            cc.WriteLine("  Thanks for using the app");
            cc.Space();
            Thread.Sleep(2000);
        }
    }
}
