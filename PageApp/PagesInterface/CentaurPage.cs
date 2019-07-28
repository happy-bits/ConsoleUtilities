using ConsoleUtilities;
using ConsoleUtilities.PageMenusInterface;

namespace PageApp.PagesInterface
{
    public class CentaurPage : IHasNextPage
    {
        public string Name => "Vain Centaur";

        public IPage NextPage { get; set; }

        public void Run()
        {
            var cc = new ConsoleCompanion(2);
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
