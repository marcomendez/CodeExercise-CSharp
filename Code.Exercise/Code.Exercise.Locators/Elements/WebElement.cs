using Code.Exercise.Helper.Enums;
using Code.Exercise.Locators.Interfaces;
using Code.Exercise.Locators.Locators;
using Code.Exercise.WebManager;

namespace Code.Exercise.Locators.Elements
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
