using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EspoAutoTests.tests
{
    [TestFixture, Order(3)]
    public class EditContactTest : TestBase
    {
        [Test, Order(3)]
        public void Test3_EditContact()
        {
            driver.Navigate().GoToUrl("https://demo.eu.espocrm.com/");
            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".fa-id-badge")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".list-row:nth-child(1) .btn")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Edit")).Click();
            Thread.Sleep(2000);

            IWebElement lastNameField = driver.FindElement(By.CssSelector(".col-sm-5 > .form-control"));
            lastNameField.Clear();
            Thread.Sleep(500);
            lastNameField.SendKeys("Min");

            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(2000);
        }
    }
}
