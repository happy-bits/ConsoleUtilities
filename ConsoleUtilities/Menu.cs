﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUtilities
{
    public class Menu
    {
        public Menu(string question, bool ignoreCase = true, bool trim = true)
        {
            Question = question;
            IgnoreCase = ignoreCase;
            Trim = trim;
        }

        public void Add(string key, string text, Action action)
        {
            if (IgnoreCase)
                _items.Add(key.ToUpper(), new TextAction(key, text, action));
            else
                _items.Add(key, new TextAction(key, text, action));
        }

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

        public string[] Keys => _items.Keys.ToArray();

        public string Question { get; }
        public bool IgnoreCase { get; }
        public bool Trim { get; }

        public string GetChoiseText(string key)
        {
            return $"{Get(key).KeyText}) {Get(key).Text}";
        }

        public TextAction Get(string key) => IgnoreCase ? _items[key.ToUpper()] : _items[key];

        public bool IsEmpty() => _items.Count == 0;

        public bool HasKey(string answer) => IgnoreCase ? Keys.Contains(answer.ToUpper()) : Keys.Contains(answer);

        private readonly Dictionary<string, TextAction> _items = new Dictionary<string, TextAction>();

    }
}
