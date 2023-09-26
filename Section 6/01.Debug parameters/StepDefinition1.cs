using TechTalk.SpecFlow;

namespace SpecflowProject3
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"I am on the product detail page of product ""(.*)""")]
        public void GivenIAmOnTheProductDetailPageOfProduct(int productId)
        {

        }

        [Given(@"product ""(.*)"" has a stock level of ""(.*)""")]
        public void GivenProductHasAStockLevelOf(int productId, int stockLevel)
        {

        }

        [Given(@"product ""(.*)"" basket quantity is ""(.*)""")]
        public void GivenProductBasketQuantityIs(int p0, int p1)
        {

        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {

        }

        [Then(@"product ""(.*)"" basket quantity is ""(.*)""")]
        public void ThenProductBasketQuatityIs(int p0, int p1)
        {

        }

        [Then(@"and a message is displayed to the customer")]
        public void AndAMessageIsDisplayToTheCustomer()
        {

        }
    }
}