using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;

namespace Code.Exercise.Elements.Interfaces
{
    public interface IWebElement
    {
        string Name { get; set; }

        ElementType ElementType { get; set; }

        Locator Locator { get; set; }
    }
}
