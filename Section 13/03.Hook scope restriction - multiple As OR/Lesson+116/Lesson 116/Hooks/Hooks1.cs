using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject6.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
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