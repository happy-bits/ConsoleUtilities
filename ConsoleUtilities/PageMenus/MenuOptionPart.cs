using System;

namespace ConsoleUtilities.PageMenus
{
    public class MenuOptionPart
    {
        public Action Action { get; }
        public string Description { get; }

        public MenuOptionPart(string description, Action action)
        {
            Description = description;
            Action = action;
        }
    }
}
