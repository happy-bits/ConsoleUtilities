using System;

namespace ConsoleUtilities.PageMenus
{
    public class MenuOption
    {
        public MenuOption(char key, string description, Action action)
        {
            Key = key;
            Description = description;
            Action = action;
        }

        public char Key { get; }
        public string Description { get; }
        public Action Action { get; }
    }
}
