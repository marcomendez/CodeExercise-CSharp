using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;
using Code.Exercise.WebManager;
using OpenQA.Selenium.Interactions;

namespace Code.Exercise.Elements.Elements
{
    public class WebElement : Interfaces.IWebElement
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

        public virtual void Hover()
        {
            Actions action = new Actions(WebDriverManager.Instance.WebDriver);
            action.MoveToElement(Element).Perform();
        }

        public virtual string GetText()
        {
            return Element.Text;
        }

        public virtual bool IsDisplayed()
        {
            try
            {
                return Element.Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
}
