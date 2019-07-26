using ConsoleUtilities;

namespace PageApp.Pages
{
    public class MainMenuPage : Page
    {
        public override string Name { get => "Main menu"; }

        public override  PageMenu PageMenu => new PageMenu {
            { "Calculator", () => new CalculatorPage() },
            { "Look at donkey", () => new DonkeyPage() },
            { "Go to centaur", () => new CentaurPage() },
            { "End program", () => new EndPage() },
        };

    }
}
