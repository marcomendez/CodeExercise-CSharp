using Code.Exercise.Helper.Enums;
using Code.Exercise.Locators.Locators;

namespace Code.Exercise.Locators.Interfaces
{
    public interface IWebElement
    {
        string Name { get; set; }

        ElementType ElementType { get; set; }

        Locator Locator { get; set; }
    }
}
