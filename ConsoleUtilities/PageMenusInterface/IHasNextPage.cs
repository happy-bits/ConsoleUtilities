namespace ConsoleUtilities.PageMenusInterface
{
    public interface IHasNextPage : IPage
    {
        IPage NextPage { get; set; }
    }
}
