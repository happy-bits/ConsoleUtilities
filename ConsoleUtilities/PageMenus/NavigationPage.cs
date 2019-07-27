namespace ConsoleUtilities.PageMenus
{
    public abstract class NavigationPage : Page
    {
        public override void BeginExecute()
        {
            foreach (var x in PageMenuNav)
                PageMenu.Add(x.Description, () => NextPage = x.Page);
        }

        protected abstract PageMenuNav PageMenuNav { get; }
    }
}
