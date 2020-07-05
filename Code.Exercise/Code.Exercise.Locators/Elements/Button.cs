using Code.Exercise.Helper.Enums;
using Code.Exercise.Locators.Interfaces;
using Code.Exercise.Locators.Locators;

namespace Code.Exercise.Locators.Elements
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
