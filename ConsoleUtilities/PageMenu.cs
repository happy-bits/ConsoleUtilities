using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUtilities
{
    public class PageMenu
    {
        private ConsoleCompanion cc = new ConsoleCompanion();

        public List<MenuOption> MenuOptions { get; set; } = new List<MenuOption>();

        private List<char> allMenuKeys = new List<char>();

        internal void Fill(List<MenuOptionPart> menuOptionParts)
        {
            foreach (var mop in menuOptionParts)
            {
                char key = (char)('a' + MenuOptions.Count);
                allMenuKeys.Add(key);
                MenuOptions.Add(new MenuOption(key, mop.Description, mop.Action));
            }
        }

        public void Run()
        {
            char answer = cc.AskForKey(allMenuKeys);
            ExecuteAction(answer);
        }

        private void ExecuteAction(char answer)
        {
            MenuOptions.Single(x => x.Key == answer).Action();
        }
    }
}
