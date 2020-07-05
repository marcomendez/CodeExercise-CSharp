using Code.Exercise.Steps;
using Code.Exercise.WebManager;
using TechTalk.SpecFlow;

namespace Code.Exercise.Features.Hooks
{
    [Binding]
    public sealed class BaseHooks : BaseSteps
    {
        public BaseHooks(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [After]
        public void After()
        {
            WebDriverManager.Instance.Close();
        }
    }
}
