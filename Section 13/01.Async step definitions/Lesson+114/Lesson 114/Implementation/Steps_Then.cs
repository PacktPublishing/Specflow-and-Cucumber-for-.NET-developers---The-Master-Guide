using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Then
    {
        private ProductTestDataContext _productTestDataContext;
        private ClothesSizeContext _clothesSizeContext;

        public Steps_Then(ProductTestDataContext productTestDataContext, ClothesSizeContext clothesSizeContext)
        {
            _productTestDataContext = productTestDataContext;
            _clothesSizeContext = clothesSizeContext;
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

        [Then(@"the clothing data is translated as the following")]
        public void ThenTheClothingDataIsTranslatedAsTheFollowing(Table table)
        {
            table.CompareToSet<Clothes_Size>(_clothesSizeContext.Clothes_Size);
        }

        [Then(@"the offer is valid")]
        public async Task ThenTheOfferIsValid()
        {

        }

        [Then(@"the offer is not valid")]
        public void ThenTheOfferIsNotValid()
        {

        }


    }
}