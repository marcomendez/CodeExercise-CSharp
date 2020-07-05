using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;

namespace Code.Exercise.Elements.Elements
{
    /// <summary>
    /// Handles Label type elements.
    /// </summary>
    public class Label : WebElement
    {
        public Label(Locator locator) : base(ElementType.Label, locator)
        {
        }
    }
}
