namespace ConsoleUtilities.PageMenus
{
    public class DescPage
    {
        public DescPage(string description, Page page)
        {
            Description = description;
            Page = page;
        }
        public string Description { get; set; }
        public Page Page { get; set; }

    }
}
