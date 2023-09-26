using System.Collections.Generic;

namespace SpecFlowProject3
{
    public static class Products
    {
        private static IEnumerable<ProductQuantities> _productWithQuantities;
        private static ProductQuantities _testingProduct;

        public static IEnumerable<ProductQuantities> ProductQuantities
        {
            get { return _productWithQuantities; }
            set { _productWithQuantities = value; }
        }

        public static ProductQuantities TestingProduct { get { return _testingProduct; } set { _testingProduct = value; } }
    }

    public class ProductQuantities
    {
        [TableAliases("Product ID")]
        public string ProductID { get; set; }
        [TableAliases("Stock Qty")]
        public int StockQty { get; set; }
        public int Basket { get; set; }
    }
}