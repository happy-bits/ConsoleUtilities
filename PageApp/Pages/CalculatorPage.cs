using ConsoleUtilities;

namespace PageApp.Pages
{
    public class CalculatorPage : Page
    {
        public override string Name => "Calculator";

        public override PageMenu PageMenu => new PageMenu {
            { "Add", () => new AdditionPage() },
            { "Multiply", () => new MultiplicationPage()},
            { "Go to main menu", () => new MainMenuPage() },
        };
    }
}
