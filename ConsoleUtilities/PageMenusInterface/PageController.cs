using System;

namespace ConsoleUtilities.PageMenusInterface
{
    public class PageController
    {
        private ConsoleCompanion cc = new ConsoleCompanion(2);

        public IPage[] Pages { get; private set; }

        public void Start(IPage page)
        {
            while (true)
            {
                INavigationPage npage = page as INavigationPage;
                IHasNextPage hpage = page as IHasNextPage;

                if (npage != null)
                    page = RenderNavigationPage(npage);
                else if (hpage != null)
                    page = RenderHasNextPage(hpage);
                else
                    break;
            }
        }

        private IPage RenderNavigationPage(INavigationPage page)
        {
            DisplayHeader(page);
            DisplayMenu(page);

            page.Run();
            return page.PageMenu.GetNextNavigationPage();
        }

        private IPage RenderHasNextPage(IHasNextPage page)
        {
            DisplayHeader(page);
            page.Run();
            return page.NextPage;
        }

        private void DisplayMenu(INavigationPage navigationPage)
        {
            // todo: able to change how menu is displayed
            foreach (var menuOption in navigationPage.PageMenu.MenuOptions)
                cc.WriteLine($"{menuOption.Key}) {menuOption.Description}");

            cc.Space();
        }

        protected void DisplayHeader(IPage page)
        {
            // todo: able to change header
            Console.Clear(); // todo: clear without flicker?
            cc.Line(ConsoleColor.DarkGray);
            cc.WriteLineDark($"{page.Name.ToUpper()}");
            cc.Line(ConsoleColor.DarkGray);
            cc.Space();
        }
    }
}
