using ConsoleUtilities.PageMenus;

namespace PageApp.Pages
{
    public class MainMenuPage : Page
    {
        public override string Name { get => "Main menu"; }

        protected override  PageMenu PageMenu => new PageMenu {
            { "Calculator", () => NextPage = new CalculatorPage() },
            { "Look at donkey", () => NextPage = new DonkeyPage() },
            { "Go to centaur", () => NextPage = new CentaurPage() },
            { "End program", () => NextPage = new EndPage() },
        };

    }
}
