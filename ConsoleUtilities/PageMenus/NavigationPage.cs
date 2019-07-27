namespace ConsoleUtilities.PageMenus
{
    public abstract class NavigationPage : Page
    {
        protected override void Execute()
        {
            foreach (var x in PageMenuNav)
                _pageMenu.Add(x.Description, () => NextPage = x.Page);

            DisplayHeader();

            DisplayMenu();

            Run();

            _pageMenu.Run();

        }

        protected abstract PageMenuNav PageMenuNav { get; }

        private void DisplayMenu()
        {
            // todo: able to change how menu is displayed
            foreach (var menuOption in _pageMenu)
                cc.WriteLine($"{menuOption.Key}) {menuOption.Description}");

            cc.Space();
        }

        private PageMenu _pageMenu = new PageMenu();
    }
}
