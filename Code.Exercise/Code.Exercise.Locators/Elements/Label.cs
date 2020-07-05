using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;

namespace Code.Exercise.Elements.Elements
{
    public class Label : WebElement
    {
        public Label(string name, Locator locator) : base(name, ElementType.Label, locator)
        {
        }
    }
}
