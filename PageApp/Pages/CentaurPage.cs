using ConsoleUtilities.PageMenus;

namespace PageApp.Pages
{
    public class CentaurPage : Page
    {
        public override string Name => "Vain Centaur";

        public override void Run()
        {

            cc.WriteLineCyan(@"         =*===                          ");
            cc.WriteLineCyan(@"       $$- - $$$                        ");
            cc.WriteLineCyan(@"       $ <    D$$                       ");
            cc.WriteLineCyan(@"       $ -   $$$                        ");
            cc.WriteLineCyan(@" ,     $$$$  |                          ");
            cc.WriteLineCyan(@"///; ,---' _ |----.                     ");
            cc.WriteLineCyan(@" \ )(           /  )                    ");
            cc.WriteLineCyan(@" | \/ \.   '  _.|  \              $     ");
            cc.WriteLineCyan(@" |  \ /(   /    /\_ \          $$$$$    ");
            cc.WriteLineCyan(@"  \ /  (       / /  )         $$$ $$$   ");
            cc.WriteLineCyan(@"       (  ,   /_/ ,`_,-----.,$$  $$$    ");
            cc.WriteLineCyan(@"       |   <----|  \---##     \   $$    ");
            cc.WriteLineCyan(@"       /         \\\           |    $   ");
            cc.WriteLineCyan(@"      '   '                    |        ");
            cc.WriteLineCyan(@"      |                 \      /        ");
            cc.WriteLineCyan(@"      /  \_|    /______,/     /         ");
            cc.WriteLineCyan(@"     /   / |   /    |   |    /          ");
            cc.WriteLineCyan(@"    (   /--|  /.     \  (\  (_          ");
            cc.WriteLineCyan(@"     `----,( ( _\     \ / / ,/          ");
            cc.WriteLineCyan(@"           | /        /,_/,/            ");
            cc.WriteLineCyan(@"          _|/        / / (              ");
            cc.WriteLineCyan(@"         / (        ^-/, |              ");

            cc.WriteLine("Press 'y' to go to main menu");
            cc.AskForKey(new char[] { 'y', 'Y' });
            NextPage = new MainMenuPage();
        }
    }
}
