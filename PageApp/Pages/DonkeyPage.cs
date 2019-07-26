using ConsoleUtilities;
using System.Collections.Generic;

namespace PageApp.Pages
{
    public class DonkeyPage : Page
    {
        public override string Name => "Donkey";

        public override List<MenuOptionPart> MenuOptionParts => null;

        public override void Run()
        {
            cc.WriteLine(@"                            /\          /\   ");
            cc.WriteLine(@"                           ( \\        // )  ");
            cc.WriteLine(@"                            \ \\      // /   ");
            cc.WriteLine(@"                             \_\\||||//_/    ");
            cc.WriteLine(@"                              \/ _  _ \      ");
            cc.WriteLine(@"                             \/|(O)(O)|      ");
            cc.WriteLine(@"                            \/ |      |      ");
            cc.WriteLine(@"        ___________________\/  \      /      ");
            cc.WriteLine(@"       //                //     |____|       ");
            cc.WriteLine(@"      //                ||     /      \      ");
            cc.WriteLine(@"     //|                \|     \ 0  0 /      ");
            cc.WriteLine(@"    // \       )         V    / \____/       ");
            cc.WriteLine(@"   //   \     /        (     /               ");
            cc.WriteLine(@"  ""     \   /_________|  |_/                ");
            cc.WriteLine(@"         /  /\   /     |  ||                 ");
            cc.WriteLine(@"        /  / /  /      \  ||                 ");
            cc.WriteLine(@"        | |  | |        | ||                 ");
            cc.WriteLine(@"        | |  | |        | ||                 ");
            cc.WriteLine(@"        |_|  |_|        |_||                 ");
            cc.WriteLine(@"         \_\  \_\        \_\\                ");
            cc.Space();
            cc.WriteLine("  Press 'y' to go to main menu");
            cc.AskForKey(new char[] { 'y', 'Y' });
            new MainMenuPage();
        }
    }
}
