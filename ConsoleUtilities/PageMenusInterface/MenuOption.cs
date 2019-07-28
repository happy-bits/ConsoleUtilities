namespace ConsoleUtilities.PageMenusInterface

{
    public class MenuOption
    {
        public MenuOption(char key, string description, IPage page)
        {
            Key = key;
            Description = description;
            Page = page;
        }

        public char Key { get; }
        public string Description { get; set; }
        public IPage Page { get; set; }

    }
}
