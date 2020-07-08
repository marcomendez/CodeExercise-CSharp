using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;

namespace Code.Exercise.Elements.Elements
{
    /// <summary>
    /// Handles button type elements.
    /// </summary>
    public class Button : WebElement, IClickeable
    {
        /// <summary>
        /// Constructors.
        /// </summary>
        /// <param name="locator">Locator info.</param>
        public Button(Locator locator) : base(locator)
        {
        }

        /// <summary>
        /// Clicks on Element.
        /// </summary>
        public void Click()
        {
            Element.Click();
        }
    }
}
