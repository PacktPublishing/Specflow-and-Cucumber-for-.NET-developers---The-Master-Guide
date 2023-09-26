using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject3
{
    public class ClothesSizeRetriever : IValueRetriever
    {
        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            return propertyType == typeof(InternalSize);
        }

        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            switch (keyValuePair.Value)
            {
                case "XXL":
                    return new InternalSize { InternalName = "ExtraExtraLarge", Width = "240cm", Height = "240cm" };
                case "L":
                    return new InternalSize { InternalName = "Large", Width = "200cm", Height = "200cm" };
                case "S":
                    return new InternalSize { InternalName = "Small", Width = "140cm", Height = "140cm" };
                default:
                    return new InternalSize { InternalName = "Unknown" };
            }
        }
    }
}