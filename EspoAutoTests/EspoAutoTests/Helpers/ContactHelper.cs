using EspoAutoTests.Model;
using OpenQA.Selenium;

namespace EspoAutoTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(AppManager manager)
            : base(manager)
        {
        }

        public void InitContactCreation()
        {
            driver.FindElement(By.CssSelector(".btn-xs-wide > span:nth-child(2)")).Click();
            Thread.Sleep(2000);
        }

        public void FillContactForm(ContactData contact)
        {
            driver.FindElement(By.CssSelector(".row:nth-child(1) > .col-sm-4 > .form-control")).SendKeys(contact.FirstName);
            if (contact.LastName != null)
            {
                driver.FindElement(By.CssSelector(".col-sm-5 > .form-control")).SendKeys(contact.LastName);
            }
        }

        public void SubmitContactCreation()
        {
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(2000);
        }


        public void SelectFirstContact()
        {
            driver.FindElement(By.CssSelector(".list-row:nth-child(1) .btn")).Click();
            Thread.Sleep(1000);
        }

        public void InitContactModification()
        {
            driver.FindElement(By.LinkText("Edit")).Click();
            Thread.Sleep(2000);
        }

        public void ModifyContactForm(ContactData contact)
        {
            if (contact.FirstName != null)
            {
                IWebElement firstNameField = driver.FindElement(By.CssSelector(".row:nth-child(1) > .col-sm-4 > .form-control"));
                firstNameField.Clear();
                Thread.Sleep(500);
                firstNameField.SendKeys(contact.FirstName);
            }

            if (contact.LastName != null)
            {
                IWebElement lastNameField = driver.FindElement(By.CssSelector(".col-sm-5 > .form-control"));
                lastNameField.Clear();
                Thread.Sleep(500);
                lastNameField.SendKeys(contact.LastName);
            }
        }

        public void SubmitContactModification()
        {
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(2000);
        }

        public void RemoveContact()
        {
            driver.FindElement(By.LinkText("Remove")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector(".btn-danger")).Click();
            Thread.Sleep(2000);
        }


        public string GetContactFullNameFromPage()
        {
            string rawTitle = driver.FindElement(By.CssSelector(".header-title")).Text;
            return rawTitle.Replace("Contacts", "").Replace("Контакт", "").Trim();
        }
    }
}
