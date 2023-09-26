using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject6.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {

        }

        [BeforeScenario]
        [Scope(Feature = "Calculator", Scenario = "Add two numbers")]
        public void BeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}