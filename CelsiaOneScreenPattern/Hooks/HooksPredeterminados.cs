using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace CelsiaOneScreenPattern.Hooks
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
            Thread.Sleep(3000);
            _scenarioContext.Get<EdgeDriver>("driver").Quit();
        }
    }
}
