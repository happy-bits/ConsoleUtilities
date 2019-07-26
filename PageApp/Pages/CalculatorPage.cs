using ConsoleUtilities;

namespace PageApp.Pages
{
    public class CalculatorPage : Page
    {
        public override string Name => "Calculator";

        protected override PageMenu PageMenu => new PageMenu {
            { "Add", () => NextPage = new AdditionPage() },
            { "Multiply", () => NextPage = new MultiplicationPage()},
            { "Go to main menu",  () => NextPage = new MainMenuPage() },
        };
    }
}
