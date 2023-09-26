using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;
using System.Linq;
using static BusinessCore.Model;

namespace SpecflowProject3.Implementation
{
    [Binding]
    public class Steps_Given
    {
        private ProductTestDataContext _productTestDataContext;
        private ClothesSizeContext _clothesSizeContext;

        public Steps_Given(ProductTestDataContext productTestDataContext, ClothesSizeContext clothesSizeContext)
        {
            _productTestDataContext = productTestDataContext;
            _clothesSizeContext = clothesSizeContext;
        }

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(IEnumerable<ProductQuantities> productQuantities)
        {
            _productTestDataContext.ProductWithQuantities = productQuantities;
        }

        [Given(@"I am on the product detail page of product '(.*)'")]
        public void GivenIAmOnTheProductDetailPageOfProduct(string productId)
        {
            _productTestDataContext.TestingProduct = _productTestDataContext.ProductWithQuantities.FirstOrDefault(t => t.ProductID == productId);
        }

        [Given(@"I have the following offer codes")]
        public void GivenIHaveTheFollowingOfferCodes(IEnumerable<OfferCodes> offerCodes)
        {
            var result = offerCodes;
        }

        [Given(@"today is '(.*)'")]
        public void GivenTodayIs(DateTime today)
        {

        }


        [Given(@"I have offer code '(.*}' which expires in '(.*)'")]
        [Given(@"I have offer code '(.*)' which expired '(.*)'")]
        public void GivenIHaveOfferCodeWhichExpiresIn(string offerCode, DateTime dateTime)
        {

        }

        [Given(@"I have the following clothes size data")]
        public void GivenIHaveTheFollowingClothesSizeData(Table table)
        {
            _clothesSizeContext.Clothes_Sizes = table.CreateSet<Clothes_Size>();
        }

        [Given(@"I have the following stores")]
        public void GivenIHaveTheFollowingStores(Table table)
        {
            var result = table.CreateDynamicSet();

            var stores = new List<Stores>();
            foreach (var entry in result)
            {
                var store = new Stores();
                store.StoreName = entry.StoreName.ToUpper();

                var coords = entry.GeoLocation.Split(',');

                store.GeoLocation = new GeoLocation { Longitude = coords[0], Latitude = coords[1] };
                stores.Add(store);
            }
        }

        [Given(@"I am the '(.*)' customer to view the offer page")]
        public void GivenIAmTheCustomerToViewTheOfferPage(int index)
        {

        }
    }
}