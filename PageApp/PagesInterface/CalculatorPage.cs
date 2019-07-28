using ConsoleUtilities.PageMenusInterface;

namespace PageApp.PagesInterface
{
    public class CalculatorPage : INavigationPage
    {
        public string Name => "Calculator";

        public PageMenu PageMenu => new PageMenu
        {
            { "Add", new AdditionPage() },
            { "Multiply", new MultiplicationPage() },
            { "Go to main menu",  new MainMenuPage() },
        };

        public void Run()
        {
        }
    }
}
