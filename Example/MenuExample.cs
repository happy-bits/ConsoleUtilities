using ConsoleUtilities;

namespace Example
{
    public class MenuExample
    {
        static int number = 0;
        static readonly ConsoleCompanion cc = new ConsoleCompanion();

        internal static void Run()
        {
            var menu = new Menu("Enter command: ");
            menu.Add("a", "Add ten", AddTen);
            menu.Add("b", "Multiply by four", MultiplyByFour);
            menu.Add("c", "Subtract by five", SubtractByFive);

            cc.DisplayMenu(menu);
            DisplayNumber();

            cc.DisplayMenu(menu);
            DisplayNumber();

            cc.DisplayMenu(menu);
            DisplayNumber();

        }

        private static void DisplayNumber()
        {
            cc.WriteLineGreen($"Number is now {number}\n");
        }

        private static void AddTen() => number += 10;
        private static void MultiplyByFour() => number *= 4;
        private static void SubtractByFive() => number -= 5;

    }
}
