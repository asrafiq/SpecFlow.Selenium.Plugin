﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Example
{
    using TechTalk.SpecFlow;
    using Autofac;
    using Autofac.Configuration;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ExampleFeature")]
    public partial class ExampleFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private OpenQA.Selenium.IWebDriver driver;
        
        private IContainer container;
        
#line 1 "ExampleFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUp()]
        public virtual void FeatureSetup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader());
            this.container = builder.Build();
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ExampleFeature", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDown()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
            try {((Unickq.SeleniumHelper.WebDriverGrid.ICustomRemoteWebDriver) this.driver).UpdateTestResult();} catch (System.Exception e) {System.Console.WriteLine(e.Message);}
            try {System.Threading.Thread.Sleep(50); this.driver.Quit(); } catch (System.Exception) {}
            this.driver = null;
            ScenarioContext.Current.Remove("Driver");
            ScenarioContext.Current.Remove("Container");
              System.Console.WriteLine(NUnit.Framework.TestContext.CurrentContext.Result.Outcome.Status.ToString());
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            if(this.driver != null)
            ScenarioContext.Current.Add("Driver", this.driver);
            if(this.container != null)
              ScenarioContext.Current.Add("Container", this.container);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        private void InitializeSelenium(string browser)
        {
            this.driver = this.container.ResolveNamed<OpenQA.Selenium.IWebDriver>(browser);
        }
        
        public virtual void CheckWebsiteTitles(string uRL, string titlePart, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser:BrowserStack",
                    "Browser:TestingBot",
                    "Browser:SauceLabs"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check website titles", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given(string.Format("I have opened {0}", uRL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.Then(string.Format("the titls should contains {0}", titlePart), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check website titles: http://google.com")]
        [NUnit.Framework.TestCaseAttribute("BrowserStack", Category="BrowserStack", TestName="CheckWebsiteTitles_HttpGoogle_Com on BrowserStack")]
        [NUnit.Framework.TestCaseAttribute("TestingBot", Category="TestingBot", TestName="CheckWebsiteTitles_HttpGoogle_Com on TestingBot")]
        [NUnit.Framework.TestCaseAttribute("SauceLabs", Category="SauceLabs", TestName="CheckWebsiteTitles_HttpGoogle_Com on SauceLabs")]
        public virtual void CheckWebsiteTitles_HttpGoogle_Com(string browser)
        {
            InitializeSelenium(browser);
            this.CheckWebsiteTitles("http://google.com", "google", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
