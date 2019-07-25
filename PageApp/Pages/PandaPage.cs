﻿using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageApp.Pages
{
    public class PandaPage : Page
    {
        public override string Name => "Panda";

        public override List<MenuOptionPart> MenuOptionParts => null;

        public override void Run()
        {
            cc.WriteLine("Here are some pandas!");
            cc.Space();
            cc.WriteLine("Press 'y' to go to main menu");
            cc.AskForKey(new char[] { 'y','Y' });
            new MainMenuPage();
        }
    }
}
