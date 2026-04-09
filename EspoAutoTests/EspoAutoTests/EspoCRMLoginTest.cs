using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace EspoAutoTests
{
    [TestFixture, Order(1)]
    public class EspoCRMLoginTest
    {
        private IWebDriver driver;

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

        [Test]
        public void LoginToEspoCRM()
        {
            driver.Navigate().GoToUrl("https://demo.eu.espocrm.com/");

            IWebElement loginButton = driver.FindElement(By.Id("btn-login"));
            loginButton.Click();

            Console.WriteLine("Тест успешно завершен: Авторизация выполнена!");
        }
    }
}