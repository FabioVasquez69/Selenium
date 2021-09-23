using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace CelsiaOnePageObject.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.XPath, Using = "//li[text()='INGRESO / REGISTRO']")]
        private IWebElement linkIngresoRegistro;

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Ingresar correo electrónico')]")]
        private IWebElement inputCorreoElectronico;
        [FindsBy(How = How.XPath, Using = "//input[contains(@type,'password')]")]
        private IWebElement inputContrasena;

        [FindsBy(How = How.XPath, Using = "//ion-button[contains(@class,'celsia-login-button')]")]
        private IWebElement buttonIngresar;

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void ClickLinkIngresoRegistro( )
        {
            linkIngresoRegistro.Click();
        }
        public void EscribirUsuario(String usuario)
        {
            this.inputCorreoElectronico.SendKeys(usuario);
        }
        public void EscribirContrasena(string contrasena)
        {
            inputContrasena.SendKeys(contrasena);
        }
        public void ClickButtonIngresar()
        {
            buttonIngresar.Click();
        }
    }
}
