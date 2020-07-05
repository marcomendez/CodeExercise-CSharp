using Code.Exercise.Steps;
using TechTalk.SpecFlow;

namespace Code.Exercise.Features.Hooks
{
    [Binding]
    public sealed class BaseHooks : BaseSteps
    {
        public BaseHooks(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
