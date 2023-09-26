using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Then : ContextHelper
    {
        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var comparisonList = ProductContext.ProductWithQuantities.Where(t => t.ProductID == ProductContext.TestingProduct.ProductID);
            table.CompareToSet<ProductQuantities>(comparisonList);
        }


        [Then(@"a message '(.*)' is displayed to the customer")]
        public void ThenAMessageIsDisplayedToTheCustomer(string p0)
        {

        }
    }
}