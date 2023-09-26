using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Linq;

namespace SpecflowProject3.Implementation
{
    public partial class MyStepDefinition
    {
        [Then(@"a message '(.*)' is displayed to the customer")]
        public void ThenAMessageIsDisplayedToTheCustomer(string p0)
        {

        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var comparisonList = productWithQuantities.Where(t => t.ProductID == testingProduct.ProductID);
            table.CompareToSet<ProductQuantities>(comparisonList);
        }
    }
}