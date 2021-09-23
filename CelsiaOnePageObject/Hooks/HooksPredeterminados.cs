using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;

namespace CelsiaOnePageObject.Hooks
{
    [Binding]
    public class HooksPredeterminados
    {
        private ScenarioContext _scenarioContext;

        public HooksPredeterminados(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUpDriver()
        {
            EdgeOptions options = new EdgeOptions();
            options.AddAdditionalCapability("--incognito", "start-maximized");

            EdgeDriver driver = new EdgeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            _scenarioContext.Add("driver", driver);
        }

        [AfterScenario]
        public void CerrarDriver()
        {
            _scenarioContext.Get<EdgeDriver>("driver").Quit();
        }
    }
}
