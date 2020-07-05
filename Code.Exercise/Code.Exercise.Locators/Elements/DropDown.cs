using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;

namespace Code.Exercise.Elements.Elements
{
    public class DropDown : WebElement, IClickeable
    {
        public DropDown(string name, Locator locator) : base(name, ElementType.DropDown, locator)
        {
        }

        public void Click()
        {
            Element.Click();
        }
    }
}
