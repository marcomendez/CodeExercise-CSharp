using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;

namespace Code.Exercise.Elements.Elements
{
    public class Button : WebElement, IClickeable
    {
        public Button(string name, Locator locator) : base(name, ElementType.Button, locator)
        {
        }

        public void Click()
        {
            Element.Click();
        }
    }
}
