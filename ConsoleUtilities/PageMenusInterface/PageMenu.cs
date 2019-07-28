using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUtilities.PageMenusInterface
{
    public class PageMenu : IEnumerable<MenuOption>
    {
        public void Add(string description, IPage page)
        {
            // todo: can configure which chars to use in the menu 
            char key = (char)('a' + MenuOptions.Count);
            MenuOptions.Add(new MenuOption(key, description, page));
        }

        public IEnumerator<MenuOption> GetEnumerator() => MenuOptions.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => MenuOptions.GetEnumerator();

        public List<MenuOption> MenuOptions { get; } = new List<MenuOption>();

        private IEnumerable<char> AllMenuKeys => MenuOptions.Select(x => x.Key);

        public IPage GetNextNavigationPage()
        {
            // todo: can configure which chars to use in the menu 
            char answer = new ConsoleCompanion().AskForKey(AllMenuKeys);
            int index = answer - 'a';

            return MenuOptions.Select(x => x.Page).ToArray()[index];

        }

    }
}

