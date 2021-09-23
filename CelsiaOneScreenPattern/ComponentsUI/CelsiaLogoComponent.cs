using System;
using System.Collections.Generic;
using System.Text;
using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;

namespace CelsiaOneScreenPattern.ComponentsUI
{
    public static class CelsiaLogoComponent
    {
        public readonly static IWebLocator CelsiaLogo = new WebLocator("Celsia Button", By.XPath("//div[contains(@class,'logo-container')]"));
    }
}
