using System.Threading;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using CelsiaOneScreenPattern.Abilities;
using CelsiaOneScreenPattern.ComponentsUI;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CelsiaOneScreenPattern.Steps
{
    [Binding]
    class SearchProductStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private IActor actor;

        public SearchProductStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"(.*) is on Mis productos")]
        public void GivenUserIsOnMisProductos(string nameActor)
        {

            IWebDriver driver = _scenarioContext.Get<IWebDriver>("driver");
            actor = new Actor(nameActor);
            actor.Can(BrowseTheWeb.With(driver));
            actor.Can(LoginAbilitie.Login(actor)); 
            //actor.AttemptsTo(Navigate.ToUrl("http://pv30098:8090/celsiaonefront/dashboard/mis-productos"));
        }

        [When(@"user is doing a search")]
        public void WhenActorIsDoingASearch()
        {
            actor.AttemptsTo(Click.On(MisProductosComponent.SearchButton));
            actor.AttemptsTo(SendKeys.To(MisProductosComponent.SearchInput, "0760862169"));
            actor.AttemptsTo(Click.On(MisProductosComponent.SearchButton));
        }

        [Then(@"user should see the product that he searched")]
        public void ThenActorShouldSeeTheProductThatHeSearched()
        {
            actor.AsksFor(Appearance.Of(MisProductosComponent.ProductItem)).Should().BeTrue();
        }
    }
}
