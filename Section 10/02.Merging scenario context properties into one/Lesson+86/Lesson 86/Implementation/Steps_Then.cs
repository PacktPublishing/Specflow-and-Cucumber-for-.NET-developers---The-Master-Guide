using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Then
    {
        private ScenarioContext _scenarioContext;

        public Steps_Then(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var productContext = (ProductTestDataContext)_scenarioContext[ContextConstants.TESTINGPRODUCTCONTEXT];
            var comparisonList = productContext.ProductWithQuantities.Where(t => t.ProductID == productContext.TestingProduct.ProductID);
            table.CompareToSet<ProductQuantities>(comparisonList);
        }


        [Then(@"a message '(.*)' is displayed to the customer")]
        public void ThenAMessageIsDisplayedToTheCustomer(string p0)
        {

        }
    }
}