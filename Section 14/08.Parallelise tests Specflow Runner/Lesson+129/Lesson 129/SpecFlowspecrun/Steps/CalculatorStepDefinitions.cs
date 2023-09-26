using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowspecrun.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"a step with delay (.*)")]
        public void GivenAStepWithDelay(int p0)
        {
            System.Threading.Thread.Sleep(p0 * 1000);
        }


        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            Assert.IsTrue(true);

           // true.Should().BeTrue();
        }
    }
}
