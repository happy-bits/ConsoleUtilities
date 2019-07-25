using System;
using System.Collections.Generic;

namespace ConsoleUtilities
{
    abstract public class Page
    {
        public abstract string Name { get; }
        public PageMenu PageMenu { get; } = new PageMenu();
        public abstract void Run();

        public abstract List<MenuOptionPart> MenuOptionParts { get; } 

        protected ConsoleCompanion cc = new ConsoleCompanion();

        private bool PageHasMenu => MenuOptionParts != null && MenuOptionParts.Count > 0;

        public Page()
        {
            Console.Clear();
            DisplayHeader();

            if (PageHasMenu)
            {
                PageMenu.Fill(MenuOptionParts);
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
            cc.Space();
            cc.WriteGreen(Name);
            cc.Space();
        }

        private void DisplayMenu()
        {
            if (PageHasMenu)
            {
                foreach (var menuOption in PageMenu.MenuOptions)
                    cc.WriteLine($" {menuOption.Key}) {menuOption.Description}");

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
