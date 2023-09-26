using TechTalk.SpecFlow;

namespace SpecflowProject3
{
    [Binding]
    public class StepDefinitions
    {
        private int _productId;

        [Given(@"I am on the product detail page of product ""(.*)""")]
        public void GivenIAmOnTheProductDetailPageOfProduct(int ProductId)
        {
            if (!int.TryParse(ProductId, out _productId))
            {
                throw new ArgumentOutOfRangeException(nameof(ProductId));
            }
        }

        [Given(@"product ""(.*)"" has a stock level of ""(.*)""")]
        public void GivenProductHasAStockLevelOf(int productId, int stockLevel)
        {

        }

        [Then(@"a message is displayed to the customer")]
        public void ThenAMessageIsDisplayToTheCustomer()
        {

        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {

        }
    }
}