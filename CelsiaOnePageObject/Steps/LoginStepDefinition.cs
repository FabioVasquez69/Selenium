using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using CelsiaOnePageObject.Pages;
using FluentAssertions;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium; 

namespace CelsiaOnePageObject.Steps
{
    [Binding]
    public class LoginStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private EdgeDriver driver;
        private LoginPage loginPage;
        private MisProductosPage misProductosPage;

        public LoginStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            driver = _scenarioContext.Get<EdgeDriver>("driver");
            loginPage = new LoginPage(driver);
            misProductosPage = new MisProductosPage(driver);
        }
        [Given(@"user is on CelsiaOne")]
        public void GivenUserIsOnCelsiaOne()
        {
            driver.Navigate().GoToUrl("http://pv30098:8090/celsiaonefront/");
        }

        [When(@"user logins on the portal")]
        public void WhenUserLoginsOnThePortal()
        {
            loginPage.ClickLinkIngresoRegistro();
            loginPage.EscribirUsuario("webmdm2017@celsia.com");
            loginPage.EscribirContrasena("Webmdm2017");
            loginPage.ClickButtonIngresar();
        }

        [Then(@"user should see the products")]
        public void ThenUserShouldSeeTheProducts()
        {
            misProductosPage.LabelHolaUserIsVisible().Should().BeTrue();
        }
    }

}
