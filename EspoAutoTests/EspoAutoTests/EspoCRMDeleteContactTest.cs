using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EspoAutoTests
{
    [TestFixture, Order(4)]
    public class DeleteContactTest : TestBase
    {

        [Test, Order(4)]
        public void Test4_DeleteContact()
        {
            driver.Navigate().GoToUrl("https://demo.eu.espocrm.com/");
            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".fa-id-badge")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".list-row:nth-child(1) .btn")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Remove")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector(".btn-danger")).Click();
            Thread.Sleep(2000);
        }
    }
}
