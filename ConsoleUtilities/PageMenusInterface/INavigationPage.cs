namespace ConsoleUtilities.PageMenusInterface
{
    public interface INavigationPage: IPage
    {
        PageMenu PageMenu { get; }
    }
}