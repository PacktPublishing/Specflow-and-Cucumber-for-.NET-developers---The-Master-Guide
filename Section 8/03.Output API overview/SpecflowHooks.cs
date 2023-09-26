using TechTalk.SpecFlow;
using System.Diagnostics;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.ValueRetrievers;
using TestingUtils;

namespace SpecFlowProject3
{
    private readonly ISpecFlowOutputHelper _outputHelper;

    public SpecflowHooks(ISpecFlowOutputHelper outputHelper)
    {
      _outputHelper = outputHelper;
    }

    [Binding]
    public sealed class SpecflowHooks
    {
      [BeforeTestRun]
      public static void BeforeTestRun()
      {
        Debug.WriteLine(nameof(BeforeTestRun));
      }

      [AfterTestRun]
      public static void AfterTestRun()
      {
        Debug.WriteLine(nameof(AfterTestRun));
      }

      [BeforeFeature]
      public static void BeforeFeature(FeatureContext featureContext)
      {
        Debug.WriteLine($"Before Feature: Feature Title: {featureContext.FeatureInfo.Title} Desc:{featureContext.FeatureInfo.Description}");
      }

      [AfterFeature]
      public static void AfterFeature(FeatureContext featureContext) 
      {
        Debug.WriteLine($"After Feature: Feature Title: {featureContext.FeatureInfo.Title} Desc:{featureContext.FeatureInfo.Description}");
      }

      [BeforeScenario]
      public void BeforeScenario(ScenarioContext scenarioContext)
      {
        _outputHelper.WriteLine($"Before Scenario: Title {scenarioContext.ScenarioInfo.Title}");
        _outputHelper.WriteLine($"Status:{scenarioContext.ScenarioExecution.Status.ToString()}");
      }

      [AfterScenario]
      public void AfterScenario()
      {
        Debug.WriteLine(nameof(AfterScenario));
      }

      [BeforeScenarioBlock]
      public void BeforeScenarioBlock()
      {
        Debug.WriteLine(nameof(BeforeScenarioBlock));
      }

      [AfterScenarioBlock]
      public void AfterScenarioBlock()
      {
        Debug.WriteLine(nameof(AfterScenarioBlock));
      }

      [BeforeStep]
      public void BeforeStep(ScenarioContext scenarioContext)
      {
        _outputHelper.WriteLine($"Text:{scenarioContext.StepContext.StepInfo.Text}");
        _outputHelper.WriteLine($"Status:{scenarioContext.StepContext.Status.ToString()}");
        _outputHelper.WriteLine(nameOf(BeforeStep));
      }

      [AfterStep]
      public void AfterStep()
      {
        Debug.WriteLine(nameof(AfterStep));
      }
    }
}
