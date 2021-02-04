using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parabank.UITests
{
    public class ParabankWebAppShould
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage() 
        {
            using (IWebDriver driver = new ChromeDriver()) 
            {
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/about.htm");
            }
        }
    }
}
