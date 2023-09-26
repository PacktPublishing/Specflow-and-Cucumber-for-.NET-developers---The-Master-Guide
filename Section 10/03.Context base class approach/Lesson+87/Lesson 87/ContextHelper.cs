using System;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject3
{
    public class ContextHelper : Steps
    {
        protected ProductTestDataContext ProductContext
        {
            get
            {
                ProductTestDataContext result = new ProductTestDataContext();
                if (ScenarioContext.ContainsKey(ContextConstants.TESTINGPRODUCTCONTEXT) == false)
                {
                    result.ProductWithQuantities = new List<ProductQuantities>();
                    ScenarioContext.Add(ContextConstants.TESTINGPRODUCTCONTEXT, result);
                }
                else
                {
                    result = (ProductTestDataContext)ScenarioContext[ContextConstants.TESTINGPRODUCTCONTEXT];
                }

                return result;
            }
        }
    }
}