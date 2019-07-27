using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUtilities
{
    public class PageMenu:IEnumerable<MenuOption>
    {

        public IEnumerator<MenuOption> GetEnumerator() => menuOptions.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => menuOptions.GetEnumerator();

        // (This method must be namned "Add" to make object initialization work)

        public void Add(string description, Action action)
        {
            char key = (char)('a' + menuOptions.Count);
            _allMenuKeys.Add(key);
            menuOptions.Add(new MenuOption(key, description, action));
        }

        public void Run()
        {
            char answer = _cc.AskForKey(_allMenuKeys);
            ExecuteAction(answer);
        }

        private List<MenuOption> menuOptions = new List<MenuOption>();

        private void ExecuteAction(char answer)
        {
            menuOptions.Single(x => x.Key == answer).Action();
        }

        private readonly ConsoleCompanion _cc = new ConsoleCompanion();
        private readonly List<char> _allMenuKeys = new List<char>();
    }
}
