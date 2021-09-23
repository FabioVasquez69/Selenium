using TechTalk.SpecFlow;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
//using System.Threading;
using Selenium_with_Gherkin.Pages;
using FluentAssertions;

namespace Selenium_with_Gherkin.Steps
{
    [Binding]
    public sealed class LoginStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private EdgeDriver driver;
        private LoginPage loginPage;
        public LoginStepDefinitions(ScenarioContext _scenarioContext)
        {
            this._scenarioContext = _scenarioContext;
            driver = _scenarioContext.Get<EdgeDriver>("driver");
            loginPage = new LoginPage(driver);
        }

        [Given(@"Página de inicio de sesion")]
        public void GivenPaginaDeInicioDeSesion()
        {
            driver.Navigate().GoToUrl("http://pv30098:8090/celsiaonefront/");
        }

        [When(@"Se ingresan las credenciales")]
        public void WhenElSeIngresanCredenciales()
        {


            loginPage.ClickLinkIngresoRegistro();
            loginPage.EscribirUsuario("webmdm2017@celsia.com");
            loginPage.EscribirContrasena("Webmdm2017");
            loginPage.ClickButtonIngresar();

        }

        [Then(@"Debería de ver la página de mis productos")]
        public void ThenDeberiaDeVerLaPaginaDeMisProductos()
        {
            driver.FindElementByXPath("//ion-grid[contains(@class,'mis-productos-content')]").Displayed.Should().BeTrue();

        }
    }
}
