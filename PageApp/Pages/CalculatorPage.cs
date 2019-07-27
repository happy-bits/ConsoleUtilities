using ConsoleUtilities.PageMenus;

namespace PageApp.Pages
{
    public class CalculatorPage : Page
    {
        public override string Name => "Calculator";

        // todo: kunna skapa en menu ännu enklare (bara genom string, Page)

        protected override PageMenu PageMenu => new PageMenu {
            { "Add", () => NextPage = new AdditionPage() },
            { "Multiply", () => NextPage = new MultiplicationPage()},
            { "Go to main menu",  () => NextPage = new MainMenuPage() },
        };
    }
}
