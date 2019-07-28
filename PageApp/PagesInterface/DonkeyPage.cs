using ConsoleUtilities;
using ConsoleUtilities.PageMenusInterface;

namespace PageApp.PagesInterface
{
    public class DonkeyPage : IHasNextPage
    {
        public string Name => "Donkey";

        public IPage NextPage { get; set; }

        public void Run()
        {
            var cc = new ConsoleCompanion(2);
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
