using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;

namespace Code.Exercise.Elements.Elements
{
    /// <summary>
    /// Handles DropDown type elements.
    /// </summary>
    public class DropDown : WebElement, IClickeable
    {
        public DropDown(Locator locator) : base(ElementType.DropDown, locator)
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
