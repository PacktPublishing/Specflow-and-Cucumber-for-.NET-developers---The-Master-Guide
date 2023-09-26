using TechTalk.SpecFlow;

namespace SpecFlowProject7XUnit.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given(@"a step with delay (.*)")]
        public void GivenAStepWithDelay(int delay)
        {
            System.Threading.Thread.Sleep(delay * 1000);
        }

    }
}
