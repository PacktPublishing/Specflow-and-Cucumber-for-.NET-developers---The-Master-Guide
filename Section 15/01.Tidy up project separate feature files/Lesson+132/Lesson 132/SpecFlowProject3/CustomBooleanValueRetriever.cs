using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject3
{
    public class CustomBooleanValueRetriever
    {
        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            switch (keyValuePair.Value.ToLowerInvariant())
            {
                case "true":
                case "false":
                case "t":
                case "f":
                case "yes":
                case "no":
                    return true;
                default:
                    return false;
            }
        }

        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            switch (keyValuePair.Value.ToLowerInvariant())
            {
                case "true":
                case "t":
                case "yes":
                    return true;

                case "false":
                case "f":
                case "no":
                    return false;
                    
                default:
                    return false;
            }
        }
    }
}