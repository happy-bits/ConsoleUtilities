using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageApp.Pages
{
    public class EndPage : Page
    {
        public override string Name => "End program";

        public override List<MenuOptionPart> MenuOptionParts => null;

        public override void Run()
        {
            cc.WriteLine("Thanks for using the app");
            cc.Space();
            Thread.Sleep(2000);
        }
    }
}
