﻿using ConsoleUtilities;
using PageApp.Pages;

namespace PageApp
{
    class Program
    {
        static ConsoleCompanion cc = new ConsoleCompanion();

        static void Main()
        {
            cc.FullScreen();
            Page.Next = new MainMenuPage();
            Page.Start();
        }
    }
}
