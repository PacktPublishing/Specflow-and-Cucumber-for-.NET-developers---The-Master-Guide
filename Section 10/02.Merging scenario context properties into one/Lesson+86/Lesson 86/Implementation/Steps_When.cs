using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_When
    {
        private ScenarioContext _scenarioContext;

        public Steps_When(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            var productContext = (ProductTestDataContext)_scenarioContext[ContextConstants.TESTINGPRODUCTCONTEXT];

            if (productContext.TestingProduct.StockQty > 0 && productContext.TestingProduct.Basket == 0)
            {
                productContext.TestingProduct.Basket++;
                productContext.TestingProduct.StockQty--;
            }

            _scenarioContext[ContextConstants.TESTINGPRODUCTCONTEXT] = productContext;
        }

    }
}