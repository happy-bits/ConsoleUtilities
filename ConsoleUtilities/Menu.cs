using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUtilities
{
    public class Menu
    {
        public class TextAction
        {
            public TextAction(string text, Action action)
            {
                Text = text;
                Action = action;
            }

            public string Text { get; }
            public Action Action { get; }
        }
        Dictionary<string, TextAction> _items = new Dictionary<string, TextAction>();

        public Menu(string question, bool ignoreCase = true, bool trim = true)
        {
            Question = question;
            IgnoreCase = ignoreCase;
            Trim = trim;
        }

        public string[] Keys => _items.Keys.ToArray();

        public string Question { get; }
        public bool IgnoreCase { get; }
        public bool Trim { get; }

        public void Add(string key, string text, Action action)
        {
            _items.Add(key, new TextAction(text, action));
        }

        internal TextAction Get(string key)
        {
            return _items[key];
        }

        internal bool IsEmpty()
        {
            return _items.Count == 0;
        }

    }
}
