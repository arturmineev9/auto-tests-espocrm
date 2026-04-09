using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EspoAutoTests
{
    public class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--incognito");
            options.AddArgument("--lang=en-US");

            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        public void GoToHomePage()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://demo.eu.espocrm.com/");
        }

        public void Login()
        {
            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(2000);
        }

        public void GoToContactsPage()
        {
            driver.FindElement(By.CssSelector(".fa-id-badge")).Click();
            Thread.Sleep(2000);
        }
    }
}
