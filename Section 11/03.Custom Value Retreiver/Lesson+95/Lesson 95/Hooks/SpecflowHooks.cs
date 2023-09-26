using TechTalk.SpecFlow;
using System.Diagnostics;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.ValueRetrievers;
using TestingUtils;

namespace SpecFlowProject3
{
    private readonly ISpecFlowOutputHelper _outputHelper;
    private readonly FeatureContext _featureContext;
    private readonly ScenarioContext _scenarioContext;

    public SpecflowHooks(ISpecFlowOutputHelper outputHelper, FeatureContext featureContext, ScenarioContext scenarioContext)
    {
      _outputHelper = outputHelper;
      _featureContext = featureContext;
      _scenarioContext = scenarioContext;
    }

    [Binding]
    public sealed class SpecflowHooks
    {
      [BeforeTestRun]
      public static void BeforeTestRun(ITestRunnerManager testRunnerManager)
      {
        
        Service.Instance.ValueRetrievers.Register(new ClothesSizeRetriever());

        var location = testRunnerManager.TestAssembly.Location;
        var threadId = testRunner.ThreadId;
        
        Debug.WriteLine(nameof(BeforeTestRun));
        // TODO: Initialise database here
        // TODO: start a transaction in this hook
        // TODO: start browser instance
      }

      [AfterTestRun]
      public static void AfterTestRun()
      {
        // TODO: Tear down database or reset database
        Debug.WriteLine(nameof(AfterTestRun));
        // TODO: rollback the transaction here
        // TODO: close browser instance
      }

      [BeforeFeature]
      public static void BeforeFeature(FeatureContext featureContext)
      {
        Debug.WriteLine($"Before Feature: Feature Title: {featureContext.FeatureInfo.Title} Desc:{featureContext.FeatureInfo.Description}");
        // TODO: Initialise database here
        // TODO: start a transaction in this hook
      }

      [AfterFeature]
      public static void AfterFeature(FeatureContext featureContext) 
      {
        Debug.WriteLine($"After Feature: Feature Title: {featureContext.FeatureInfo.Title} Desc:{featureContext.FeatureInfo.Description}");
        // TODO: Tear down database or reset database
        // TODO: rollback the transaction here
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

        if (_scenarioContext.TestError != null) {
          // email
          // log to dev ops environment
          // log to data
        }
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
        // TODO: use specflow logging api to output step
      }

      [AfterStep]
      public void AfterStep()
      {
        Debug.WriteLine(nameof(AfterStep));
      }
    }
}
