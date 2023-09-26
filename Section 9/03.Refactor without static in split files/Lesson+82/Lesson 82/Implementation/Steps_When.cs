using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_When
    {
        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            if (Products.TestingProduct.StockQty > 0 && Products.TestingProduct.Basket == 0)
            {
                Products.TestingProduct.Basket++;
                Products.TestingProduct.StockQty--;
            }

        }

    }
}