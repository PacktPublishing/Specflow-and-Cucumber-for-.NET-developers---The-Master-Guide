using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;
using TechTalk.SpecFlow.UnitTestProvider;

namespace SpecflowProject3
{
    [Binding]
    public class StepDefinitions
    {
        private ProductQuantities productWithQuantities;

        private class ProductQuantities
        {
            public string ProductID { get; set; }

            [TableAliases("Stock")]
            public int StockQty { get; set; }
            public int Basket { get; set; }
        }

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            productWithQuantities = table.CreateInstance<ProductQuantities>();
        }

        [Given(@"I am on the product detail page of product (.*)")]
        public void GivenIAmOnTheProductDetailPageOfProduct(string productId)
        {

        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            table.CompareToInstance(productWithQuantities);
        }

        [Then(@"a message '(.*)' is displayed to the customer")]
        public void ThenAMessageIsDisplayToTheCustomer(string p0)
        {

        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            productWithQuantities.Basket++;
            productWithQuantities.StockQty--;
        }

    }
}