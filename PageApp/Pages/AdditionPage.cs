using ConsoleUtilities;
using System.Collections.Generic;

namespace PageApp.Pages
{
    public class AdditionPage : Page
    {
        public override string Name => "Add two numbers";

        public override List<MenuOptionPart> MenuOptionParts => null;

        public override void Run()
        {
            while (true)
            {
                double num1 = cc.AskForNumber("  Number 1: ");
                double num2 = cc.AskForNumber("  Number 2: ");
                cc.Space();
                cc.Write($"  Sum of the number is ");
                cc.WriteLineCyan(num1+num2);
                cc.Space();
                cc.WriteLine("  (A)gain of go back to (C)alculator?");
                char answer = cc.AskForKey(new[] { 'a', 'c', 'A', 'C' });
                if (answer.ToString().ToUpper() == "C")
                    break;

                cc.Space();
            }
            new CalculatorPage();
        }
    }
}
