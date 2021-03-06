﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Unickq.SpecFlow.Selenium.Example.Features
{
    using TechTalk.SpecFlow;
    using Autofac;
    using Autofac.Configuration;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("f2")]
    [NUnit.Framework.ParallelizableAttribute()]
    public partial class F2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private OpenQA.Selenium.IWebDriver driver;
        
        private IContainer container;
        
        [NUnit.Framework.OneTimeSetUp()]
        public virtual void FeatureSetup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader());
            container = builder.Build();
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "f2", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            try {((Unickq.SpecFlow.Selenium.WebDriverGrid.PaidWebDriver) driver).UpdateTestResult();} catch (System.Exception) {}
            try {System.Threading.Thread.Sleep(50); driver.Quit(); } catch (System.Exception) {}
            driver = null;
            try {testRunner.ScenarioContext.Remove("Driver");} catch (System.NullReferenceException) {}
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            if(driver != null)
              testRunner.ScenarioContext.Add("Driver", driver);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check website title")]
        [NUnit.Framework.TestCaseAttribute("ChromeDebug", "https://translate.google.com/", "Google", null, Category="ChromeDebug", TestName="CheckWebsiteTitle with ChromeDebug and \"https://translate.google.com/\" ,\"Google\"")]
        [NUnit.Framework.TestCaseAttribute("FirefoxDebug", "https://translate.google.com/", "Google", null, Category="FirefoxDebug", TestName="CheckWebsiteTitle with FirefoxDebug and \"https://translate.google.com/\" ,\"Google\"" +
            "")]
        public virtual void CheckWebsiteTitle(string browser, string uRL, string @string, string[] exampleTags)
        {
InitializeSeleniumBrowser(browser);
            string[] @__tags = new string[] {
                    "Browser:ChromeDebug",
                    "Browser:FirefoxDebug"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check website title", @__tags);
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given(string.Format("I have opened {0}", uRL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then(string.Format("the title should contain \'{0}\'", @string), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        private void InitializeSeleniumBrowser(string browser)
        {
            driver = container.ResolveNamed<OpenQA.Selenium.IWebDriver>(browser);
        }
    }
}
#pragma warning restore
#endregion
