using TechTalk.SpecFlow;
using System.Collections;

namespace SpecflowProject3
{
    [Binding]
    public class StepDefinitions
    {
        private List<ProductQuantities> productQuantities = new List<ProductQuantities>();

        private class ProductQuantities
        {
            public string Product { get; set; }
            public int Stock { get; set; }
            public int Basket { get; set; }
        }

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            var productQuantitiesStrong = table.CreateSet<ProductQuantities>();

            for (var row = 0; row < table.RowCount; row++)
            {
                productQuantities.Add(new ProductQuantities
                {
                    Product = table.Rows[row]["Product"],
                    Stock = int.Parse(table.Rows[row]["Stock"]),
                    Basket = int.Parse(table.Rows[row]["Basket"]),
                });
            }
        }

        [Given(@"I am on the product detail page of product (.*)")]
        public void GivenIAmOnTheProductDetailPageOfProduct(int p0)
        {

        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {

        }

        [Then(@"a message is displayed to the customer")]
        public void AMessageIsDisplayToTheCustomer()
        {

        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {

        }
    }
}