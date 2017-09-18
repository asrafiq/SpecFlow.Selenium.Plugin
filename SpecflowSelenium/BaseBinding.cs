using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Unickq.SeleniumHelper
{
    public class BaseBinding
    {
        protected readonly ScenarioContext ScenarioContext;
        protected readonly IWebDriver Browser;

        protected BaseBinding(ScenarioContext scenarioContext)
        {
            if (scenarioContext == null) throw new ArgumentNullException(nameof(scenarioContext));
            ScenarioContext = scenarioContext;
            Browser = scenarioContext.GetWebDriver();
        }
    }
}
