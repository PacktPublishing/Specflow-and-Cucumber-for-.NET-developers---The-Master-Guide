using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

[assembly: Parallelize(Scope = ExecutionScope.ClassLevel)]
namespace specflowmstest.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly ISpecFlowOutputHelper _outputHelper;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext, ISpecFlowOutputHelper outputHelper)
        {
            _scenarioContext = scenarioContext;
            _outputHelper = outputHelper;
        }

        [Given(@"a step with delay (.*)")]
        public void GivenAStep(int delay)
        {
            _outputHelper.WriteLine("Given at {0}", System.DateTime.Now);
            System.Threading.Thread.Sleep(delay * 1000);
        }

    }
}
