using ConsoleUtilities;

namespace PageApp.Pages
{
    public class CalculatorPage : Page
    {
        public override string Name => "Calculator";

        public override PageMenu PageMenu => new PageMenu {
            { "Add", () => Next = new AdditionPage() },
            { "Multiply", () => Next = new MultiplicationPage()},
            { "Go to main menu",  () => Next = new MainMenuPage() },
        };
    }
}
