using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;
using System.Linq;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Given
    {
        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            Products.ProductQuantities = table.CreateSet<ProductQuantities>();
        }

        [Given(@"I am on the product detail page of product '(.*)'")]
        public void GivenIAmOnTheProductDetailPageOfProduct(string productId)
        {
            Products.TestingProduct = productWithQuantities.FirstOrDefault(t => t.ProductID == productId);
        }

    }
}