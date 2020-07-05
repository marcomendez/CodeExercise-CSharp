using Code.Exercise.WebManager;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Code.Exercise.Steps
{
    [Binding]
    public sealed class GenericSteps : BaseSteps
    {
        public GenericSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }
        
        [StepDefinition(@"I go to '([^']+?)'")]
        public void NavigateToClickUp(string url)
        {
            WebDriverManager.Instance.Start(url);
        }

        [StepDefinition(@"I click ([^']+?)(?: on ([^']+?)|)")]
        public void Click(string elementName, string PageName)
        {
            Element(elementName, PageName).Click();
        }

        [StepDefinition(@"I hover on ([^']+?) and click on ([^']+?)(?: on ([^']+?)|)")]
        public void Hover(string elementToHover, string elementToClick, string PageName)
        {
            Element(elementToHover, PageName).Hover();
            Element(elementToClick, PageName).Click();
        }

        [StepDefinition(@"I verify that '([^']+?)' contains '([^']+?)'(?: on ([^']+?)|)")]
        public void VerifyThatElementContainsText(string elementName, string text, string PageName)
        {
            bool status = Element(elementName, PageName).Contains(text);
            Assert.IsTrue(status, $"The element {elementName} No contain {text}");
        }

        [StepDefinition(@"I verify that the following values are displayed(?: on ([^']+?)|)")]
        public void VerifyThatElementsAreDisplayed(string elementName, string PageName, Table table)
        {
        }
    }
}
