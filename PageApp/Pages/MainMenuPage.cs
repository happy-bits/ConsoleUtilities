using ConsoleUtilities;

namespace PageApp.Pages
{
    public class MainMenuPage : Page
    {
        public override string Name { get => "Main menu"; }

        public override  PageMenu PageMenu => new PageMenu {
            { "Calculator", () => Next = new CalculatorPage() },
            { "Look at donkey", () => Next = new DonkeyPage() },
            { "Go to centaur", () => Next = new CentaurPage() },
            { "End program", () => Next = new EndPage() },
        };

    }
}
