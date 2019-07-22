using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUtilities
{
    public class Menu
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
            if (IgnoreCase)
                _items.Add(key.ToUpper(), new TextAction(key, text, action));
            else
                _items.Add(key, new TextAction(key, text, action));
        }

        internal string GetChoiseText(string key)
        {
            return $"{Get(key).KeyText}) {Get(key).Text}";
        }

        internal TextAction Get(string key)
        {
            if (IgnoreCase)
                return _items[key.ToUpper()];

            return _items[key];
        }

        internal bool IsEmpty()
        {
            return _items.Count == 0;
        }

        internal bool HasKey(string answer)
        {
            if (IgnoreCase)
                return Keys.Contains(answer.ToUpper());

            return Keys.Contains(answer);
        }
    }
}
