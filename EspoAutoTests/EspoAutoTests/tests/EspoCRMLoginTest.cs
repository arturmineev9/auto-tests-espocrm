using OpenQA.Selenium;

namespace EspoAutoTests.tests
{
    [TestFixture, Order(1)]
    public class LoginTest : TestBase
    {

        [Test]
        public void LoginToEspoCRM()
        {
            driver.Navigate().GoToUrl("https://demo.eu.espocrm.com/");
            IWebElement loginButton = driver.FindElement(By.Id("btn-login"));
            loginButton.Click();
        }
    }
}
