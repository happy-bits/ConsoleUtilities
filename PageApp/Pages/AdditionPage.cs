using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageApp.Pages
{
    public class AdditionPage : Page
    {
        public override string Name => "Add two numbers";

        public override List<MenuOptionPart> MenuOptionParts => null;

        public override void Run()
        {
            cc.WriteLine("Number 1: ");
        }
    }
}
