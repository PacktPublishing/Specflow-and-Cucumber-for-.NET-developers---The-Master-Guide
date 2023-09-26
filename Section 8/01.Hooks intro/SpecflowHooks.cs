using TechTalk.SpecFlow;
using System.Diagnostics;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.ValueRetrievers;
using TestingUtils;

namespace SpecFlowProject3
{
    [Binding]
    public sealed class SpecflowHooks
    {
      [BeforeTestRun]
      public static void BeforeTestRun()
      {

      }

      [AfterTestRun]
      public static void AfterTestRun()
      {

      }

      [BeforeFeature]
      public static void BeforeFeature()
      {

      }

      [AfterFeature]
      public static void AfterFeature() 
      {

      }

      [BeforeScenario]
      public void BeforeScenario()
      {

      }

      [AfterScenario]
      public void AfterScenario()
      {

      }

      [BeforeScenarioBlock]
      public void BeforeScenarioBlock()
      {

      }

      [AfterScenarioBlock]
      public void AfterScenarioBlock()
      {

      }

      [BeforeStep]
      public void BeforeStep()
      {

      }

      [AfterStep]
      public void AfterStep()
      {

      }
    }
}
