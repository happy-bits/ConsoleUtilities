using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUtilities.PageMenus
{
    public class PageMenu : IEnumerable<MenuOption>
    {

        public IEnumerator<MenuOption> GetEnumerator() => _menuOptions.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _menuOptions.GetEnumerator();

        // (This method must be namned "Add" to make object initialization work)

        public void Add(string description, Action action)
        {
            // todo: may change naming of options
            char key = (char)('a' + _menuOptions.Count);
            _allMenuKeys.Add(key);
            _menuOptions.Add(new MenuOption(key, description, action));
        }

        public void Run()
        {
            char answer = _cc.AskForKey(_allMenuKeys);
            ExecuteAction(answer);
        }

        private List<MenuOption> _menuOptions = new List<MenuOption>();

        private void ExecuteAction(char answer)
        {
            _menuOptions.Single(x => x.Key == answer).Action();
        }

        private readonly ConsoleCompanion _cc = new ConsoleCompanion();
        private readonly List<char> _allMenuKeys = new List<char>();
    }
}
