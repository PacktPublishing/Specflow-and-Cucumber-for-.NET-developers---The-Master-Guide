using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;
using System.Linq;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public partial class MyStepDefinition
    {
        private IEnumerable<ProductQuantities> _productWithQuantities;
        private ProductQuantities _testingProduct;
        private ScenarioContext _scenarioContext;
        private IUnitTestRuntimeProvider _unitTestRuntimeProvider;

        private class ProductQuantities
        {
            [TableAliases("Product ID")]
            public string ProductID { get; set; }
            [TableAliases("Stock Qty")]
            public int StockQty { get; set; }
            public int Basket { get; set; }
        }

        public MyStepDefinition(ScenarioContext scenarioContext, IUnitTestRuntimeProvider unitTestRuntimeProvider)
        {
            _scenarioContext = scenarioContext;
            _unitTestRuntimeProvider = unitTestRuntimeProvider;
        }

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            _productWithQuantities = table.CreateSet<ProductQuantities>();
        }

        [Given(@"I am on the product detail page of product '(.*)'")]
        public void GivenIAmOnTheProductDetailPageOfProduct(string productId)
        {
            _testingProduct = productWithQuantities.FirstOrDefault(t => t.ProductID == productId);
        }

    }
}