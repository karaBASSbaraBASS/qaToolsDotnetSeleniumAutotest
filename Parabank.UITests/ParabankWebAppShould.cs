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
                const string homeUrl = "https://parabank.parasoft.com/parabank/about.htm";

                driver.Navigate().GoToUrl(homeUrl);

                TestHelper.Pause();

                Assert.Equal("ParaBank | About Us", driver.Title);
                Assert.Equal(homeUrl, driver.Url);
            }
        }
    }
}
