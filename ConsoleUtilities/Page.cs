using System;
using System.Linq;

namespace ConsoleUtilities
{
    abstract public class Page
    {
        public abstract string Name { get; }
        public virtual PageMenu PageMenu { get; } = new PageMenu();

        public virtual void Run()
        {
        }

        protected ConsoleCompanion cc = new ConsoleCompanion(2);

        private bool PageHasMenu => PageMenu.Any();

        public Page()
        {
            Console.Clear();
            DisplayHeader();

            if (PageHasMenu)
            {
                DisplayMenu();
                Run();
                ExecuteMenu();
            }
            else
            {
                Run();
            }
        }

        private void DisplayHeader()
        {
            cc.Line(ConsoleColor.DarkGray);
            cc.WriteLineDark($"{Name.ToUpper()}");
            cc.Line(ConsoleColor.DarkGray);
            cc.Space();
        }

        private void DisplayMenu()
        {
            if (PageHasMenu)
            {
                foreach (var menuOption in PageMenu)
                    cc.WriteLine($"{menuOption.Key}) {menuOption.Description}");

                cc.Space();
            }
        }

        private void ExecuteMenu()
        {
            if (PageHasMenu)
                PageMenu.Run();
        }
    }
}
