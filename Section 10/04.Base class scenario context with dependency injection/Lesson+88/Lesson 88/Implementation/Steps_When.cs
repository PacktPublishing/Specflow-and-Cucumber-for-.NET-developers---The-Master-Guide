using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_When : ContextHelper
    {
        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            if (ProductContext.TestingProduct.StockQty > 0 && ProductContext.TestingProduct.Basket == 0)
            {
                ProductContext.TestingProduct.Basket++;
                ProductContext.TestingProduct.StockQty--;
            }
        }

    }
}