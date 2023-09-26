using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;

namespace SpecflowProject3
{
    [Binding]
    public class StepDefinitions
    {
        private List<ProductQuantities> productQuantities = new List<ProductQuantities>();

        private class ProductQuantities
        {
            public string Product { get; set; }
            [TableAliases("Reserved Qty", "Internal Qty")]
            public int StockQty { get; set; }
            public int Basket { get; set; }
        }

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            var productQuantitiesStrong = table.CreateSet<ProductQuantities>();
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
        public void ThenAMessageIsDisplayToTheCustomer()
        {

        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {

        }
    }
}