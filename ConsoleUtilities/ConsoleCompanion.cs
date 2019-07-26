﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ConsoleUtilities
{
    public class ConsoleCompanion
    {
        public int ColumnSize { get; set; } = 20;

        public ConsoleColor AnswerColor { get; set; } = ConsoleColor.Green;

        public void Init(int width = 60, int height = 20)
        {
            Console.WindowWidth = width;
            Console.WindowHeight = height;

            Console.BufferWidth = width;

            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();  // extern hänger ihop med DllImport

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);  

        public void FullScreen()
        {
            IntPtr thisConsole = GetConsoleWindow();
            int MAXIMIZE = 3;
            /*
            int HIDE = 0;
            int MINIMIZE = 6;
            int RESTORE = 9;
            */

            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(thisConsole, MAXIMIZE);
        }

        public void DisplayMenu(Menu menu, bool addSpaceAtEnd = true)
        {
            if (menu == null || menu.IsEmpty())
                throw new ArgumentException("Invalid", nameof(menu));

            if (menu.Question == null)
                throw new ArgumentException("Invalid", nameof(menu));

            while (true)
            {
                foreach (string key in menu.Keys)
                    WriteLine(menu.GetChoiseText(key));

                Write(menu.Question);
                string answer = ReadLineGreen();

                if (addSpaceAtEnd)
                    Space();

                if (menu.Trim)
                    answer = answer.Trim();

                if (!menu.HasKey(answer))
                    continue;

                Action a = menu.Get(answer).Action;
                a();
                return;
            }

        }

        public void Line(ConsoleColor color = ConsoleColor.White, char c = '─')
        {
            string s = new string(c, Console.WindowWidth);
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }

        public char AskForKey(IEnumerable<char> allowedKeys)
        {
            while (true)
            {
                char answer = Console.ReadKey(true).KeyChar;
                if (allowedKeys.Contains(answer))
                    return answer;
            }
        }

        public void End()
        {
            Console.WriteLine();
            SetStandardColor();
            Console.ReadKey();
        }

        public void Space()
        {
            Console.WriteLine();
        }

        public void Write(object message)
        {
            SetStandardColor();
            Console.Write(message);
        }

        public void WriteLine(object message)
        {
            SetStandardColor();
            Console.WriteLine(message);
        }

        public void WriteDark(object message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(message);
        }

        public void WriteLineDark(object message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(message);
        }

        public void WriteGreen(object message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
        }

        public void WriteLineCyan(object message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
        }

        public void WriteLineGreen(object message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        public void WriteRed(object message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
        }

        public void WriteLineRed(object message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void Columns(params object[] cols)
        {
            string s = "";
            foreach (object col in cols)
            {
                if (col is ConsoleColor)
                {
                    Console.ForegroundColor = (ConsoleColor)col;
                    continue;
                }
                s += col.ToString().PadRight(ColumnSize);
            }
            WriteLine(s);
        }

        public double AskForNumber(string question)
        {
            while (true)
            {
                string x = AskForString(question);
                if (double.TryParse(x, out double answer))
                    return answer;
            }
        }

        public int AskForInteger(string question, int? from = null, int? to = null)
        {
            while (true)
            {
                string x = AskForString(question);
                if (int.TryParse(x, out int answer))
                {
                    if (from != null && answer < from)
                        continue;

                    if (to != null && answer > to)
                        continue;

                    return answer;
                }
            }
        }

        public string AskForString(string question, string defaultAnswer = null)
        {
            Write(question);
            string answer = ReadLineGreen();

            if (defaultAnswer != null && string.IsNullOrWhiteSpace(answer))
                return defaultAnswer;

            return answer;
        }

        public string AskForStringRegex(string question, string regex, bool addStartAndEndSign = true)
        {
            while (true)
            {
                Write(question);
                string answer = ReadLineGreen();

                string pattern = addStartAndEndSign ? "^" + regex + "$" : regex;

                if (Regex.IsMatch(answer, pattern))
                    return answer;
            }
        }

        public char AskForKey(string question, char[] validKeys = null, bool caseInsensitive = true)
        {
            while (true)
            {
                Write(question);

                char answer = ReadCharGreen().KeyChar;

                answer = caseInsensitive ? CharToUpper(answer) : answer;

                if (validKeys == null || validKeys.Contains(answer))
                    return answer;
            }
        }

        private void SetStandardColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        private string ReadLineGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return Console.ReadLine();
        }

        private ConsoleKeyInfo ReadCharGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return Console.ReadKey();
        }

        private char CharToUpper(char c)
        {
            if (!char.IsLetter(c))
                return c;

            return c.ToString().ToUpper()[0];
        }
    }
}

