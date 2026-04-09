using OpenQA.Selenium;

namespace EspoAutoTests.tests
{
    [TestFixture, Order(4)]
    public class DeleteContactTest : TestBase
    {
        [Test]
        public void Test4_DeleteContact()
        {
            GoToHomePage();
            Login();
            GoToContactsPage();
            SelectFirstContact();
            RemoveContact();
        }

        private void SelectFirstContact()
        {
            driver.FindElement(By.CssSelector(".list-row:nth-child(1) .btn")).Click();
            Thread.Sleep(1000);
        }

        private void RemoveContact()
        {
            driver.FindElement(By.LinkText("Remove")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector(".btn-danger")).Click();
            Thread.Sleep(2000);
        }
    }
}
