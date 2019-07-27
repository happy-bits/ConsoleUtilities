using ConsoleUtilities.PageMenus;

namespace PageApp.Pages
{
    public class CalculatorPage : NavigationPage
    {
        public override string Name => "Calculator";

        protected override PageMenuNav PageMenuNav => new PageMenuNav
        {
            { "Add", new AdditionPage() },
            { "Multiply", new MultiplicationPage() },
            { "Go to main menu",  new MainMenuPage() },
        };
    }
}
