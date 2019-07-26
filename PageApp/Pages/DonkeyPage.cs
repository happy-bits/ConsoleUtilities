using ConsoleUtilities;

namespace PageApp.Pages
{
    public class DonkeyPage : Page
    {
        public override string Name => "Donkey";

        public override void Run()
        {
            cc.WriteLineRed(@"                            /\          /\   ");
            cc.WriteLineRed(@"                           ( \\        // )  ");
            cc.WriteLineRed(@"                            \ \\      // /   ");
            cc.WriteLineRed(@"                             \_\\||||//_/    ");
            cc.WriteLineRed(@"                              \/ _  _ \      ");
            cc.WriteLineRed(@"                             \/|(O)(O)|      ");
            cc.WriteLineRed(@"                            \/ |      |      ");
            cc.WriteLineRed(@"        ___________________\/  \      /      ");
            cc.WriteLineRed(@"       //                //     |____|       ");
            cc.WriteLineRed(@"      //                ||     /      \      ");
            cc.WriteLineRed(@"     //|                \|     \ 0  0 /      ");
            cc.WriteLineRed(@"    // \       )         V    / \____/       ");
            cc.WriteLineRed(@"   //   \     /        (     /               ");
            cc.WriteLineRed(@"  ""     \   /_________|  |_/                ");
            cc.WriteLineRed(@"         /  /\   /     |  ||                 ");
            cc.WriteLineRed(@"        /  / /  /      \  ||                 ");
            cc.WriteLineRed(@"        | |  | |        | ||                 ");
            cc.WriteLineRed(@"        | |  | |        | ||                 ");
            cc.WriteLineRed(@"        |_|  |_|        |_||                 ");
            cc.WriteLineRed(@"         \_\  \_\        \_\\                ");
            cc.Space();
            cc.WriteLine("Press 'y' to go to main menu");
            cc.AskForKey(new char[] { 'y', 'Y' });
            NextPage = new MainMenuPage();
        }
    }
}
