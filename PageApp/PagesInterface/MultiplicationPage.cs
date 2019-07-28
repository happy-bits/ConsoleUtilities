using ConsoleUtilities;
using ConsoleUtilities.PageMenusInterface;

namespace PageApp.PagesInterface
{
    public class MultiplicationPage : IHasNextPage
    {
        public string Name => "Multiplication";

        public IPage NextPage { get; set; }

        public void Run()
        {
            var cc = new ConsoleCompanion(2);

            while (true)
            {
                double num1 = cc.AskForNumber("Number 1: ");
                double num2 = cc.AskForNumber("Number 2: ");
                cc.Space();
                cc.Write($"Product of the number is ");
                cc.WriteLineCyan(num1 * num2);
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
