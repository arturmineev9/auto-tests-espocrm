using EspoAutoTests.data;
using OpenQA.Selenium;

namespace EspoAutoTests.tests
{
    [TestFixture, Order(3)]
    public class EditContactTest : TestBase
    {

        [Test, Order(3)]
        public void Test3_EditContact()
        {
            ContactData newData = new ContactData("Artur") { LastName = "Min" };

            GoToHomePage();
            Login();
            GoToContactsPage();

            SelectFirstContact();
            InitContactModification();
            ModifyContactForm(newData);
            SubmitContactModification();
        }
        private void SelectFirstContact()
        {
            driver.FindElement(By.CssSelector(".list-row:nth-child(1) .btn")).Click();
            Thread.Sleep(1000);
        }

        private void InitContactModification()
        {
            driver.FindElement(By.LinkText("Edit")).Click();
            Thread.Sleep(2000);
        }

        private void ModifyContactForm(ContactData contact)
        {
            if (contact.LastName != null)
            {
                IWebElement lastNameField = driver.FindElement(By.CssSelector(".col-sm-5 > .form-control"));
                lastNameField.Clear();
                Thread.Sleep(500);
                lastNameField.SendKeys(contact.LastName);
            }
        }

        private void SubmitContactModification()
        {
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(2000);
        }
    }
}
