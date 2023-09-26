using System;
using System.Collections.Generic;
using static BusinessCore.Model;

namespace SpecFlowProject3
{
   

    public class ProductTestDataContext
    {
        public IEnumerable<ProductQuantities> ProductWithQuantities;
        public ProductQuantities TestingProduct;
    }

    public class ClothesSizeContext
    {
        public IEnumerable<Clothes_Size> ClothesSizes;
    }

    public class OfferCodesContext
    {
        public IEnumerable<OfferCodes> OfferCodes;
        public DateTime Today;
    }
   
    

}
