using ConsoleUtilities;

namespace Example
{
    class Program
    {
        static void Main()
        {
            var cc = new ConsoleCompanion();

            string name = cc.AskForStringRegex("What's your name? ", @"[a-z A-ZåäöÅÄÖ]{2,}");
            int age = cc.AskForInteger("How old are you? ",0, 100);

            cc.Space();
            cc.WriteLineDark($"Your name is {name} and you are {age} years old");
        }
    }
}
