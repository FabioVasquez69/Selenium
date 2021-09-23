//using NUnit.FrameWork;
using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using FluentAssertions;

namespace Selenium
{
	class Program
	{
		static void Main(string[] args)
		{
            /* You can find the latest version of Microsoft WebDriver here:
           * https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/
           */
            var driver = new EdgeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            // Navigate to 
            driver.Manage().Window.Maximize();
            driver.Url = "http://pv30098:8090/celsiaonefront/";

            // Find 
            driver.FindElementByXPath("//li[text()='INGRESO / REGISTRO']").Click();


            driver.FindElementByXPath("//input[contains(@placeholder,'Ingresar correo electrónico')]").SendKeys("webmdm2017@celsia.com");
            driver.FindElementByXPath("//input[contains(@type,'password')]").SendKeys("Webmdm2017");

            driver.FindElementByXPath("//ion-button[contains(@class,'celsia-login-button')]").Click();

            var isTrue= driver.FindElementByXPath("//ion-grid[contains(@class,'mis-productos-content')]").Displayed.Should().BeTrue();
            //elementById.SendKeys("HolaSelenium");

            Console.WriteLine("El inicio de sesion fue exitoso?",isTrue);
            //Console.ReadLine();
            driver.Quit();

        }
	}
}
