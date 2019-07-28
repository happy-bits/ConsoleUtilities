using ConsoleUtilities;
using ConsoleUtilities.PageMenusInterface;

namespace PageApp.PagesInterface
{
    public class AdditionPage : IHasNextPage
    {
        public string Name => "Add two numbers";

        public IPage NextPage { get; set; }

        public void Run()
        {
            // todo: get "cc" from a central place (using DI?)
            var cc = new ConsoleCompanion(2);

            while (true)
            {
                double num1 = cc.AskForNumber("Number 1: ");
                double num2 = cc.AskForNumber("Number 2: ");
                cc.Space();
                cc.Write($"Sum of the number is ");
                cc.WriteCyan(num1 + num2 + "\n");
                cc.Space();
                cc.WriteLine("(A)gain of go back to (C)alculator?");
                char answer = cc.AskForKey(new[] { 'a', 'c', 'A', 'C' });
                if (answer.ToString().ToUpper() == "C")
                    break;

                cc.Space();
            }
            NextPage = new CalculatorPage();
        }
    }
}
