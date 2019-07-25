using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageApp.Pages
{
    public class MainMenuPage : Page
    {
        public override string Name { get => "Main menu"; }

        public override List<MenuOptionPart> MenuOptionParts => new List<MenuOptionPart> {
            new MenuOptionPart("Calculator", () => new CalculatorPage()),
            new MenuOptionPart("Look at pandas", () => new PandaPage()),
            new MenuOptionPart("End program", Quit)
        };

        public override void Run()
        {
        }

        private void Quit()
        {
            cc.Space();
            Console.WriteLine("Thanks for using the app");
            Thread.Sleep(3000);
        }
    }
}
