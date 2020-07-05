using Code.Exercise.Elements.Elements;
using Code.Exercise.Helper.Attributes;
using Code.Exercise.Helper.Enums;

namespace Code.Exercise.Pages
{
    [Page("Index")]
    public class Index
    {
        [Element("BEST SELLERS", ElementType.Button)]
        [Locator(LocatorType.CssSelector, "a[href='#blockbestsellers']")]
        public Button BestSellers { get; }
    }
}
