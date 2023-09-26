using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Then
    {
        private ProductTestDataContext _productTestDataContext;

        public Steps_Then(ProductTestDataContext productTestDataContext)
        {
            _productTestDataContext = productTestDataContext;
        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var comparisonList = ProductContext.ProductWithQuantities.Where(t => t.ProductID == _productTestDataContext.TestingProduct.ProductID);
            table.CompareToSet<ProductQuantities>(comparisonList);
        }


        [Then(@"a message '(.*)' is displayed to the customer")]
        public void ThenAMessageIsDisplayedToTheCustomer(string p0)
        {

        }

        [Then(@"the offer is valid")]
        public void ThenTheOfferIsValid()
        {

        }
    }
}