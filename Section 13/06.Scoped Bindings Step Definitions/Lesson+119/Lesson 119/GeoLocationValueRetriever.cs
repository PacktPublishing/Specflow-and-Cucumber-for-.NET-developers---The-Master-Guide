using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject3
{
    public class GeoLocationValueRetriever : IValueRetriever
    {
        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            return propertyType == typeof(GeoLocation);
        }

        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            GeoLocation geoLocation = new GeoLocation();

            var coords = keyValuePair.Value.Split(',');
            geoLocation.Latitude = coords[0];
            geoLocation.Longitude = coords[1];

            return geoLocation;
        }
    }
}