using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUtilities
{
    public class PageMenu:IEnumerable<MenuOption>
    {
        private ConsoleCompanion cc = new ConsoleCompanion();

        private List<char> allMenuKeys = new List<char>();

        private List<MenuOption> menuOptions = new List<MenuOption>();
        public IEnumerator<MenuOption> GetEnumerator() => menuOptions.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => menuOptions.GetEnumerator();

        public void Add(string description, Action action)
        {
            char key = (char)('a' + menuOptions.Count);
            allMenuKeys.Add(key);

            menuOptions.Add(new MenuOption(key, description, action));
        }

        public void Run()
        {
            char answer = cc.AskForKey(allMenuKeys);
            ExecuteAction(answer);
        }

        private void ExecuteAction(char answer)
        {
            menuOptions.Single(x => x.Key == answer).Action();
        }


    }
}
