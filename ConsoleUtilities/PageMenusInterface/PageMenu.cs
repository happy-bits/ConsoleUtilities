using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUtilities.PageMenusInterface
{
    public class PageMenu : IEnumerable<MenuOption>
    {
        public void Add(string description, IPage page)
        {
            char key = (char)('a' + MenuOptions.Count);
            _allMenuKeys.Add(key);

            MenuOptions.Add(new MenuOption(key, description, page));
            
        }

        public IEnumerator<MenuOption> GetEnumerator() => MenuOptions.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => MenuOptions.GetEnumerator();

        public List<MenuOption> MenuOptions { get; } = new List<MenuOption>();

        private List<char> _allMenuKeys = new List<char>();

        public IPage GetNextNavigationPage()
        {
            char answer = new ConsoleCompanion().AskForKey(_allMenuKeys);
            int index = answer - 'a';

            return MenuOptions.Select(x => x.Page).ToArray()[index];

        }

    }
}

