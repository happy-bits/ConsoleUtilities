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
            double num1 = cc.AskForNumber("Number 1: ");
            double num2 = cc.AskForNumber("Number 2: ");
            cc.Space();
            cc.WriteLine($"Sum of the number is {num1 + num2}");
            cc.Space();
            cc.WriteLine("(A)gain of go back to (c)alculator?");
            char answer = cc.AskForKey(new[] { 'a', 'c','A','C' });
            if (answer.ToString().ToUpper() == "A")
                Run();
            else
                new CalculatorPage();
        }
    }
}
