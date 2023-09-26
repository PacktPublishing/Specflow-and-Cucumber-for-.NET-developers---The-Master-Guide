using System;
using System.Collections.Generic;

namespace SpecFlowProject3
{
    public class ProductQuantities
    {
        [TableAliases("Product ID")]
        public string ProductID { get; set; }
        [TableAliases("Stock Qty")]
        public int StockQty { get; set; }
        public int Basket { get; set; }
    }

    public class ProductTestDataContext
    {
        public IEnumerable<ProductQuantities> ProductWithQuantities;
        public ProductQuantities TestingProduct;
    }

    public class OfferCodesContext
    {
        public IEnumerable<OfferCodes> OfferCodes;
        public DateTime Today;
    }

    public class OfferCodes
    {
        public string OfferCode { get; set; }
        public DateTime ExpiryDate { get; set; }
        public OfferCodesType OfferCodeType { get; set; }
    }

    public enum OfferCodesType
    {
        ByDate,
        ByProduct,
        ByDay

    }

}