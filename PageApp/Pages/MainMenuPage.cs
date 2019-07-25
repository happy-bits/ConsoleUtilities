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
            new MenuOptionPart("Calculator", GotoCalc),
            new MenuOptionPart("Look at pandas", GotoPandas)
        };

        public override void Run()
        {
        }

        private void GotoPandas()
        {
            new PandaPage();
        }

        private void GotoCalc()
        {
            new CalculatorPage();
        }
    }
}
