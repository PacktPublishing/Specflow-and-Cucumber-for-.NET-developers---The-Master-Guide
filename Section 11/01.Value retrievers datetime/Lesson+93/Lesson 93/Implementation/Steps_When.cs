using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_When
    {
        private ProductTestDataContext _productTestDataContext;

        public Steps_When(ProductTestDataContext productTestDataContext)
        {
            _productTestDataContext = productTestDataContext;
        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            if (_productTestDataContext.TestingProduct.StockQty > 0 && _productTestDataContext.TestingProduct.Basket == 0)
            {
                _productTestDataContext.TestingProduct.Basket++;
                _productTestDataContext.TestingProduct.StockQty--;
            }
        }

        [When(@"I add offer code '(.*)' to the basket")]
        public void WhenIAddOfferCodeToTheBasket(string p0)
        {

        }

    }
}