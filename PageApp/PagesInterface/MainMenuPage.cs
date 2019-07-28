using ConsoleUtilities.PageMenusInterface;

namespace PageApp.PagesInterface
{
    public class MainMenuPage : INavigationPage
    {
        public string Name => "Main menu";

        public PageMenu PageMenu => new PageMenu()
        {
            { "Calculator", new CalculatorPage() },
            { "Look at donkey",  new DonkeyPage() },
            { "Go to centaur",  new CentaurPage() },
            { "End program", new EndPage() },
        };

        public void Run()
        {
        }
    }
}
