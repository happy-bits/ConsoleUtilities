﻿using ConsoleUtilities;
using System.Collections.Generic;

namespace PageApp.Pages
{
    public class MainMenuPage : Page
    {
        public override string Name { get => "Main menu"; }

        public override List<MenuOptionPart> MenuOptionParts => new List<MenuOptionPart> {
            new MenuOptionPart("Calculator", () => new CalculatorPage()),
            new MenuOptionPart("Look at pandas", () => new PandaPage()),
            new MenuOptionPart("End program", () => new EndPage())
        };

        public override void Run()
        {
        }

    }
}
