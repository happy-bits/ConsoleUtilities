using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageApp.Pages
{
    public class CalculatorPage : Page
    {
        public override string Name => "Calculator";

        public override List<MenuOptionPart> MenuOptionParts => new List<MenuOptionPart>
        {
            new MenuOptionPart("Add", GotoAdd),
            new MenuOptionPart("Multiply", GotoMultiply),
            new MenuOptionPart("Go to main menu", GotoMain),
        };

        private void GotoAdd()
        {
            new AdditionPage();
        }

        private void GotoMain()
        {
            new MainMenuPage();
        }

        private void GotoMultiply()
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
        }
    }
}
