using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace   CelsiaOnePageObject.Pages
{
    public class MisProductosPage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'company-name')]")]
        private IWebElement labelHolaUser;
        public MisProductosPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public bool LabelHolaUserIsVisible()
        {
            return labelHolaUser.Displayed;
        }
    }

}
