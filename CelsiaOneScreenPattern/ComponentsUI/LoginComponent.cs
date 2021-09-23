using System;
using System.Collections.Generic;
using System.Text;
using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;

namespace CelsiaOneScreenPattern.ComponentsUI
{
    public class LoginComponent
    {
        public readonly static IWebLocator LinkIngresoRegistro = new WebLocator("link ingreso registro",By.XPath("//li[text()='INGRESO / REGISTRO']"));
        public readonly static IWebLocator UserInput = new WebLocator("user input", By.XPath("//input[contains(@placeholder,'Ingresar correo electrónico')]"));
        public readonly static IWebLocator PasswordInput = new WebLocator("password input", By.XPath("//input[contains(@type,'password')]"));
        public readonly static IWebLocator LoginButton = new WebLocator("Login Button", By.XPath("//ion-button[contains(@class,'celsia-login-button')]"));
    }
}
