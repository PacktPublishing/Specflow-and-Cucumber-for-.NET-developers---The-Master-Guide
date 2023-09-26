using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;
using System.Linq;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Given : ContextHelper
    {
        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            ProductContext.ProductWithQuantities = table.CreateSet<ProductQuantities>();
        }

        [Given(@"I am on the product detail page of product '(.*)'")]
        public void GivenIAmOnTheProductDetailPageOfProduct(string productId)
        {
            productContext.TestingProduct = productContext.ProductWithQuantities.FirstOrDefault(t => t.ProductID == productId);
        }

    }
}