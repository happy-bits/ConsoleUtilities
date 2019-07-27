using System;

namespace ConsoleUtilities.PageMenus
{
    public abstract class Page
    {
        public abstract string Name { get; }

        public static void Start(Page startPage)
        {
            NextPage = startPage;

            while (NextPage != null)
                NextPage.Execute();
        }

        public virtual void Run() { }

        protected static Page NextPage;

        protected ConsoleCompanion cc = new ConsoleCompanion(2);

        protected virtual void Execute()
        {
            DisplayHeader();
            Run();
        }

        protected void DisplayHeader()
        {
            // todo: able to change header
            Console.Clear(); // todo: clear without flicker?
            cc.Line(ConsoleColor.DarkGray);
            cc.WriteLineDark($"{Name.ToUpper()}");
            cc.Line(ConsoleColor.DarkGray);
            cc.Space();
        }

    }
}
