using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using CelsiaOneScreenPattern.ComponentsUI;

namespace CelsiaOneScreenPattern.Steps
{
    [Binding]
    public class LoginStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private IActor actor;

        public LoginStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            
        }
        [Given(@"(.*) is on CelsiaOne")]
        public void GivenActorIsOnCelsiaOne(string nameActor)
        {
            IWebDriver driver = _scenarioContext.Get<IWebDriver>("driver");
            actor = new Actor(nameActor);
            actor.Can(BrowseTheWeb.With(driver));
            actor.AttemptsTo(Navigate.ToUrl("http://pv30098:8090/celsiaonefront/"));
        }

        [When(@"user logins on the portal")]
        public void WhenActorLoginsOnThePortal()
        {
            actor.AttemptsTo(Click.On(LoginComponent.LinkIngresoRegistro));
            actor.AttemptsTo(SendKeys.To(LoginComponent.UserInput, "webmdm2017@celsia.com"));
            actor.AttemptsTo(SendKeys.To(LoginComponent.PasswordInput, "Webmdm2017"));
            actor.AttemptsTo(Click.On(LoginComponent.LoginButton));
            
        }

        [Then(@"user should see the products")]
        public void ThenActorShouldSeeTheProducts()
        {
            actor.AsksFor(Appearance.Of(CelsiaLogoComponent.CelsiaLogo)).Should().BeTrue();
        }
    }
}
