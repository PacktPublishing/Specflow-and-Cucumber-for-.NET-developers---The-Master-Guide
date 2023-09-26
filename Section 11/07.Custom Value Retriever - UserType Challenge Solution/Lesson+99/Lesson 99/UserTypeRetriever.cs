using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject3
{
    public class UserTypeRetriever : IValueRetriever
    {
        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            return propertyType == typeof(User);
        }

        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            var value = (UserTypeEnum)Enum.Parse(typeof(UserTypeEnum), keyValuePair.Value);
            return new User { UserType = value, AccessLevel = (int)value };
        }
    }
}