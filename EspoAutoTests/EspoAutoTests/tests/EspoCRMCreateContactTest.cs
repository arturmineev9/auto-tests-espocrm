using EspoAutoTests.data;
using OpenQA.Selenium;

namespace EspoAutoTests.tests
{
    [TestFixture, Order(2)]
    public class CreateContactTest : TestBase
    {
        [Test]
        public void Test2_CreateContact()
        {
            ContactData contact = new ContactData("Artur") { LastName = "M" };

            GoToHomePage();
            Login();
            GoToContactsPage();
            InitContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
        }

        private void InitContactCreation()
        {
            driver.FindElement(By.CssSelector(".btn-xs-wide > span:nth-child(2)")).Click();
            Thread.Sleep(2000);
        }

        private void FillContactForm(ContactData contact)
        {
            driver.FindElement(By.CssSelector(".row:nth-child(1) > .col-sm-4 > .form-control")).SendKeys(contact.FirstName);

            if (contact.LastName != null)
            {
                driver.FindElement(By.CssSelector(".col-sm-5 > .form-control")).SendKeys(contact.LastName);
            }
        }

        private void SubmitContactCreation()
        {
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(2000);
        }
    }
}
