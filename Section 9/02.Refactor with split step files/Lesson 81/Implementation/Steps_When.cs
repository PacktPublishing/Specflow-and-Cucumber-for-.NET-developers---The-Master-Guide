using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowProject3.Implementation
{
    public partial class MyStepDefinition
    {
        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            if (_testingProduct.StockQty > 0 && _testingProduct.Basket == 0)
            {
                _testingProduct.Basket++;
                _testingProduct.StockQty--;
            }

        }

    }
}