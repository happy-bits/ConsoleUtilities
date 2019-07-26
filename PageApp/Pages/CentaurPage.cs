using ConsoleUtilities;
using System;

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

            Console.ReadKey();
            Next = new MainMenuPage();
        }
    }
}
