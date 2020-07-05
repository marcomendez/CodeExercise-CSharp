using Code.Exercise.Helper;
using Code.Exercise.WebManager;
using TechTalk.SpecFlow;

namespace Code.Exercise.Steps
{
    [Binding]
    public sealed class GenericSteps : BaseSteps
    {
        public GenericSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [StepDefinition(@"I go to '([^']+?)' page")]
        public void NavigateToPage(string url)
        {
            WebDriverManager.Instance.Start(PagesUrl.GetUrl(url));
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
    }
}
