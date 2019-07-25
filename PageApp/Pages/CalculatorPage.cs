using ConsoleUtilities;
using System.Collections.Generic;

namespace PageApp.Pages
{
    public class CalculatorPage : Page
    {
        public override string Name => "Calculator";

        public override List<MenuOptionPart> MenuOptionParts => new List<MenuOptionPart>
        {
            new MenuOptionPart("Add", () => new AdditionPage()),
            new MenuOptionPart("Multiply", () => new MultiplicationPage()),
            new MenuOptionPart("Go to main menu", () => new MainMenuPage()),
        };

        public override void Run()
        {
        }
    }
}
