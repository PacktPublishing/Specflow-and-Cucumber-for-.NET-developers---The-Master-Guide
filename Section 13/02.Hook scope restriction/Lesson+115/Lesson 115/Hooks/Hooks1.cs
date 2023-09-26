using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject6.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        [BeforeScenario]
        [Scope(Tag = "example")]
        public void BeforeScenario()
        {

        }

        [AfterScenario]
        [Scope(Tag = "example")]
        public void AfterScenario()
        {

        }
    }
}