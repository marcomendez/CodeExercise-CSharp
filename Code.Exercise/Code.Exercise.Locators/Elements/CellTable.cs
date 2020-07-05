using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;
namespace Code.Exercise.Elements.Elements
{
    /// <summary>
    /// Handles Cell table type elements.
    /// </summary>
    public class CellTable : WebElement, IClickeable
    {
        public CellTable(Locator locator) : base(ElementType.CellTable, locator)
        {
        }

        /// <summary>
        /// Clicks on WebElement.
        /// </summary>
        public void Click()
        {
            Element.Click();
        }
    }
}
