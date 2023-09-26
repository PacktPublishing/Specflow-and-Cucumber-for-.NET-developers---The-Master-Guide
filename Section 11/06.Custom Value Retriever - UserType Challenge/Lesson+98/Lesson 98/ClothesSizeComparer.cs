using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow.Assist;

namespace SpecflowProject3
{
    public class ClothesSizeComparer : IValueComparer
    {
        public bool CanCompare(object actualValue)
        {
            return actualValue is InternalSize;
        }

        public bool Compare(string expectedValue, object actualValue)
        {
            return (actualValue as InternalSize).InternalName == expectedValue;
        }
    }
}