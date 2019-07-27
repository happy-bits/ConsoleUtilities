using System.Collections;
using System.Collections.Generic;

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
    public class PageMenuNav : IEnumerable<DescPage>
    {
        public void Add(string description, Page page)
        {
            _descPages.Add(new DescPage(description, page));
        }

        public IEnumerator<DescPage> GetEnumerator() => _descPages.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _descPages.GetEnumerator();

        private List<DescPage> _descPages = new List<DescPage>();
    }
}
