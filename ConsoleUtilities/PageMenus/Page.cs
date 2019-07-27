using System;
using System.Linq;

namespace ConsoleUtilities.PageMenus
{
    public abstract class Page
    {
        public abstract string Name { get; }

        public static void Start(Page startPage)
        {
            NextPage = startPage;

            while (NextPage != null)
                NextPage.Execute();
        }

        public virtual void Run() { }

        protected virtual PageMenu PageMenu { get; } = new PageMenu();

        protected static Page NextPage;

        protected ConsoleCompanion cc = new ConsoleCompanion(2);

        protected void Execute()
        {
            DisplayHeader();

            if (PageHasMenu)
                DisplayMenu();

            Run();

            if (PageHasMenu)
                PageMenu.Run();
        }

        private bool PageHasMenu => PageMenu.Any();

        private void DisplayHeader()
        {
            Console.Clear(); // todo: clear without flicker?
            cc.Line(ConsoleColor.DarkGray);
            cc.WriteLineDark($"{Name.ToUpper()}");
            cc.Line(ConsoleColor.DarkGray);
            cc.Space();
        }

        private void DisplayMenu()
        {
            foreach (var menuOption in PageMenu)
                cc.WriteLine($"{menuOption.Key}) {menuOption.Description}");

            cc.Space();
        }

    }
}
