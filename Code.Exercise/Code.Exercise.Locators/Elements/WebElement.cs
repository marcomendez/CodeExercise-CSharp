using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;
using Code.Exercise.WebManager;

namespace Code.Exercise.Elements.Elements
{
    public class WebElement : IWebElement
    {
        public string Name { get; set; }
        public ElementType ElementType { get; set; }
        public Locator Locator { get; set; }

        public WebElement(string name, ElementType type, Locator locator)
        {
            Name = name;
            ElementType = type;
            Locator = locator;
        }

        public OpenQA.Selenium.IWebElement Element
        {
            get => WebDriverManager.Instance.WebDriver.FindElement(Locator.GetBy());
        }
    }
}
