using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;
using System.Linq;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Given
    {
        private ScenarioContext _scenarioContext;

        public Steps_Given(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            var productContext = ProductTestDataContext();
            var productQuantities = table.CreateSet<ProductQuantities>();
            _scenarioContext.Add(ContextConstants.TESTINGPRODUCTCONTEXT, productContext);
        }

        [Given(@"I am on the product detail page of product '(.*)'")]
        public void GivenIAmOnTheProductDetailPageOfProduct(string productId)
        {
            var productContext = (ProductTestDataContext)_scenarioContext[ContextConstants.TESTINGPRODUCTCONTEXT];
            productContext.TestingProduct = productContext.ProductWithQuantities.FirstOrDefault(t => t.ProductID == productId);
            _scenarioContext[ContextConstants.TESTINGPRODUCTCONTEXT] = productContext;
        }

    }
}