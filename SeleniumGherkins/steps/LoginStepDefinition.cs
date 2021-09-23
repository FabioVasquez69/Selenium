using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumGherkins.pages;
using FluentAssertions;
namespace SeleniumGherkins
{
    class LoginStepDefinition
    {
        static void Main(string[] args)
        {
            /* You can find the latest version of Microsoft WebDriver here:
          * https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/
          */
            var driver = new EdgeDriver();

            // Navigate to 
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.exito.com";

            // Find 

            //driver.FindElementById("user-name");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElementByXPath("//*[contains(@placeholder,'Buscar en exito.com')]").SendKeys("Televisores");
            driver.FindElementByXPath("//*[contains(text(),'Tv Led 127 Cm (50) Uhd Smart SAMSUNG 50 Pulgadas')]").Click();
            var precio = driver.FindElementByXPath("//*[contains(@class,'exito-components-4-x-priceProductPDP')]").Text;

            //elementById.SendKeys("HolaSelenium");


            //Console.ReadLine();
            driver.Quit();
        }
    }
}
