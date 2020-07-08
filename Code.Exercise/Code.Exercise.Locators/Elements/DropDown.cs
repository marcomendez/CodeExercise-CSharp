using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;

namespace Code.Exercise.Elements.Elements
{
    /// <summary>
    /// Handles DropDown type elements.
    /// </summary>
    public class DropDown : WebElement, IClickeable
    {
        public DropDown(Locator locator) : base(locator)
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
