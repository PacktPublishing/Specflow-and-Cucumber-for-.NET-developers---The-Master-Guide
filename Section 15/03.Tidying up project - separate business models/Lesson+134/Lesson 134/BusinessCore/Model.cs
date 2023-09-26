using System;

namespace BusinessCore
{
    public class Model
    {
        public class ProductQuantities
        {
            [TableAliases("Product ID")]
            public string ProductID { get; set; }
            [TableAliases("Stock Qty")]
            public int StockQty { get; set; }
            public int Basket { get; set; }
        }

        public class OfferCodes
        {
            public string OfferCode { get; set; }
            public DateTime ExpiryDate { get; set; }
            public OfferCodesType OfferCodeType { get; set; }
            public bool IsValid { get; set; }
        }



        public enum OfferCodesType
        {
            ByDate,
            ByProduct,
            ByDay
        }

        public class Clothes_Size
        {
            public string Name { get; set; }
            public InternalSize Size { get; set; }
        }

        public class InternalSize
        {
            public string InternalName { get; set; }
            public string Width { get; set; }
            public string Height { get; set; }
        }

        public enum UserTypeEnum
        {
            Supervisor,
            Staff,
            Customer,
            Visitor
        }

        public class Stores
        {
            public string StoreName { get; set; }
            public GeoLocation GeoLocation { get; set; }
        }

        public class GeoLocation
        {
            public string Longitude { get; set; }
            public string Latitude { get; set; }
        }
    }
}
