using System;
using System.Collections.Generic;
using System.Text;
using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;

namespace CelsiaOneScreenPattern.ComponentsUI
{
    class MisProductosComponent
    {
        public readonly static IWebLocator SearchButton = new WebLocator("Search button", By.XPath("//div[contains(@class,'search-ico')]"));
        public readonly static IWebLocator SearchInput = new WebLocator("Search input", By.XPath("//input[contains(@placeholder,'Buscar')]"));
        public readonly static IWebLocator ProductItem = new WebLocator("Product item", By.XPath("//div[contains(@class,'product-item')]"));
    }
}
