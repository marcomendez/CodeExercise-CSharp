using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;

namespace Code.Exercise.Elements.Elements
{
    /// <summary>
    /// Handles Cell table type elements.
    /// </summary>
    public class CellTable : WebElement, IClickeable
    {
        public CellTable(Locator locator) : base(locator)
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
