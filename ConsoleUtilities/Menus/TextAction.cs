using System;

namespace ConsoleUtilities.Menus
{
    public class TextAction
    {
        public TextAction(string keyText, string text, Action action)
        {
            KeyText = keyText;
            Text = text;
            Action = action;
        }

        public string KeyText { get; }
        public string Text { get; }
        public Action Action { get; }
    }
}
