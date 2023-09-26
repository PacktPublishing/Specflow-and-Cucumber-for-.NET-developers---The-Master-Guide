using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject6.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        [BeforeFeature]
        [Scope(Tag = "myfeature")]
        public static void BeforeFeature()
        {

        }

        [BeforeScenario]
        [Scope(Scenario = "Add two numbers")]
        [Scope(Scenario = "Add two numbers again 2")]
        [Scope(Tag = "anotherexample")]
        public void BeforeScenario()
        {

        }

        [AfterScenario]
        [Scope(Scenario = "Add two numbers")]
        public void AfterScenario()
        {

        }
    }
}