using ConsoleUtilities;

namespace PageApp.Pages
{
    public class MainMenuPage : Page
    {
        public override string Name { get => "Main menu"; }

        public override  PageMenu PageMenu => new PageMenu {
            { "Calculator", () => new CalculatorPage().Execute() },
            { "Look at donkey", () => new DonkeyPage().Execute() },
            { "Go to centaur", () => new CentaurPage().Execute() },
            { "End program", () => new EndPage().Execute() },
        };

    }
}
