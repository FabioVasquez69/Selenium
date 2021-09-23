using System.Threading;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using CelsiaOneScreenPattern.ComponentsUI;

namespace CelsiaOneScreenPattern.Abilities
{
    class LoginAbilitie : IAbility
    {
        public IActor actor { get; }

        private LoginAbilitie(IActor actor)
        {
            this.actor = actor;
            actor.AttemptsTo(Navigate.ToUrl("http://pv30098:8090/celsiaonefront/"));
            actor.AttemptsTo(Click.On(LoginComponent.LinkIngresoRegistro));
            actor.AttemptsTo(SendKeys.To(LoginComponent.UserInput, "webmdm2017@celsia.com"));
            actor.AttemptsTo(SendKeys.To(LoginComponent.PasswordInput, "Webmdm2017"));
            actor.AttemptsTo(Click.On(LoginComponent.LoginButton));
        }
        public static LoginAbilitie Login(IActor actor)
        {
            return new LoginAbilitie(actor);
        }
    }
}
