using ConsoleUtilities.PageMenus;

namespace PageApp.Pages
{
    public class MainMenuPage : NavigationPage
    {
        public override string Name { get => "Main menu"; }

        protected override PageMenuNav PageMenuNav => new PageMenuNav {
            { "Calculator", new CalculatorPage() },
            { "Look at donkey",  new DonkeyPage() },
            { "Go to centaur",  new CentaurPage() },
            { "End program", new EndPage() },
        };
    }
}
