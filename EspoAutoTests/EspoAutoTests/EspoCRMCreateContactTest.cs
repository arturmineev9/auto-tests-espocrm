using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EspoAutoTests
{
    [TestFixture, Order(2)]
    public class CreateContactTest
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

        [Test, Order(2)]
        public void Test2_CreateContact()
        {
            driver.Navigate().GoToUrl("https://demo.eu.espocrm.com/");
            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".fa-id-badge")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".btn-xs-wide > span:nth-child(2)")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".row:nth-child(1) > .col-sm-4 > .form-control")).SendKeys("Artur");
            driver.FindElement(By.CssSelector(".col-sm-5 > .form-control")).SendKeys("M");

            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(2000);

            Console.WriteLine("Тест 2 пройден: Контакт Artur M создан.");
        }
    }
}
