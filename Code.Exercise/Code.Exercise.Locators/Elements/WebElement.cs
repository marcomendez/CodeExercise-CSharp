using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;
using Code.Exercise.WebManager;
using OpenQA.Selenium.Interactions;

namespace Code.Exercise.Elements.Elements
{
    /// <summary>
    /// Handles basic WebElement actions.
    /// </summary>
    public class WebElement : IWebElement
    {
        public ElementType ElementType { get; set; }
        public Locator Locator { get; set; }

        /// <summary>
        /// Constructors.
        /// </summary>
        /// <param name="type">Element type (e. Button, Label, TextBox, etc.)</param>
        /// <param name="locator">Locator informaton (e. a[href='#blockbestsellers']).</param>
        public WebElement(ElementType type, Locator locator)
        {
            ElementType = type;
            Locator = locator;
        }

        /// <summary>
        /// Gets WebElement found.
        /// </summary>
        public OpenQA.Selenium.IWebElement Element
        {

            get => WebDriverManager.Instance.WebDriver.FindElement(Locator.GetBy());
        }

        /// <summary>
        /// Makes hover on a WebElement.
        /// </summary>
        public virtual void Hover()
        {
            Actions action = new Actions(WebDriverManager.Instance.WebDriver);
            action.MoveToElement(Element).Perform();
        }

        /// <summary>
        /// Gets text from a WebElement.
        /// </summary>
        /// <returns>Webelement text.</returns>
        public virtual string GetText()
        {
            return Element.Text;
        }

        /// <summary>
        /// Checks if WebElement is displayed on DOM.
        /// </summary>
        /// <returns>True if webelemenet id displayed, false otherwise.</returns>
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
