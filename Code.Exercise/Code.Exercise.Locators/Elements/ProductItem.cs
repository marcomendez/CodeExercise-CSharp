using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;
namespace Code.Exercise.Elements.Elements
{
   public class CellTable : WebElement, IClickeable
    {
        public CellTable(string name, Locator locator) : base(name, ElementType.CellTable, locator)
        {
        }

        public void Click()
        {
            Element.Click();
        }
    }
}
