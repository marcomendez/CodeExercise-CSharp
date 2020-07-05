using Code.Exercise.Elements.Elements;
using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Entities;
using Code.Exercise.Helper.Enums;
using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Code.Exercise.Steps
{
    [Binding]
    public sealed class GenericValidations : BaseSteps
    {
        public GenericValidations(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [StepDefinition(@"I verify that '([^']+?)' contains '([^']+?)'(?: on ([^']+?)|)")]
        public void VerifyThatElementContainsText(string elementName, string text, string PageName)
        {
            string actualResult = Element(elementName, PageName).GetText();
            Assert.AreEqual(text, actualResult, $"The element {elementName} no contain {text}");
        }

        [StepDefinition(@"I verify that the following values are( not|) displayed on table")]
        public void VerifyThatElementsDisplayed(string not, Table table)
        {
            var products = table.CreateSet<Product>();
            
            foreach (Product item in products)
            {
                string row = $"*//table/descendant::tr[td['Description'][contains(., '{item.Description}')] and td['Avail'][contains(., '{item.Avail}')] ]";

                CellTable cellTable = new CellTable(new Locator(LocatorType.XPath, row));

                if(string.IsNullOrEmpty(not))
                {
                    Assert.IsTrue(cellTable.IsDisplayed(), $"Prouct {item.Description} was not displayed on table.");
                }
                else
                {
                    Thread.Sleep(2000);
                    Assert.False(cellTable.IsDisplayed(), $"Prouct {item.Description} was displayed on table.");
                }
            }
        }
    }
}
