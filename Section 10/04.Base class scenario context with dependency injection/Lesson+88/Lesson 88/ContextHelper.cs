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
                return ScenarioContext.ScenarioContainer.Resolve<ProductTestDataContext>();
            }
        }
    }

    // customer context

    // offer context
}