﻿using ConsoleUtilities;
using PageApp.Pages;
using System;
using System.Runtime.InteropServices;

namespace PageApp
{
    class Program
    {
        static ConsoleCompanion cc = new ConsoleCompanion();

        static void Main()
        {
            cc.FullScreen();
            new MainMenuPage();
        }
    }
}
