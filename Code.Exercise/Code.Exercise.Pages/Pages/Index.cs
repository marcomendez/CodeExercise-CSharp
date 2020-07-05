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

        [Element("Printed Chiffon Dress", ElementType.Label)]
        [Locator(LocatorType.XPath, "//*[text()[contains(.,'Printed Chiffon Dress')]]/../../../../..//li[1]//div[2]/div/span[3]")]
        public Label PrintedChiffonDress { get; }

        [Element("Blouse", ElementType.Label)]
        [Locator(LocatorType.XPath, "//*[contains(@class,'first-item-of-mobile-line')]//*[@alt='Blouse']")]
        public Label Blouse { get; }

        [Element("Add to cart", ElementType.Button)]
        [Locator(LocatorType.XPath, "//*[contains(@class,'hovered')]//*[text()[contains(.,'Add to cart')]]")]
        public Button AddToCart { get; }

        [Element("Cart", ElementType.DropDown)]
        [Locator(LocatorType.CssSelector, "a[title = 'View my shopping cart']")]
        public DropDown Cart { get; }

        [Element("Check out", ElementType.Button)]
        [Locator(LocatorType.Id, "button_order_cart")]
        public Button CheckOut { get; }
        [Element("Continue shopping", ElementType.Button)]
        [Locator(LocatorType.CssSelector, "span[title = 'Continue shopping']")]
        public Button ContinueShopping { get; }
    }
}
