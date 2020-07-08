using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;

namespace Code.Exercise.Elements.Interfaces
{
    public interface IWebElement
    {
        Locator Locator { get; set; }
    }
}
