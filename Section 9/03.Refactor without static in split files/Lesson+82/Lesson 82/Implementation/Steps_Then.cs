using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Linq;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Then
    {
        [Then(@"a message '(.*)' is displayed to the customer")]
        public void ThenAMessageIsDisplayedToTheCustomer(string p0)
        {

        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var comparisonList = Products.ProductWithQuantities.Where(t => t.ProductID == Products.TestingProduct.ProductID);
            table.CompareToSet<ProductQuantities>(comparisonList);
        }
    }
}