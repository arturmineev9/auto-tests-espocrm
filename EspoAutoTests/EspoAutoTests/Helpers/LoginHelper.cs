using EspoAutoTests.Model;
using OpenQA.Selenium;

namespace EspoAutoTests.Helpers
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(AppManager manager) : base(manager) { }

        public void Login(AccountData account)
        {
            // 1. УМНАЯ ПРОВЕРКА
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account.Username))
                {
                    return;
                }
                Logout();
            }

            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(2000); 
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.Id("nav-menu-dropdown")).Click();
                Thread.Sleep(500); // Ждем анимацию открытия

                driver.FindElement(By.CssSelector("a[data-name='logout']")).Click();
                Thread.Sleep(1000);
            }
        }

        public bool IsLoggedIn()
        {
            return driver.FindElements(By.Id("nav-menu-dropdown")).Count > 0;
        }

        public bool IsLoggedIn(string username)
        {
            if (!IsLoggedIn()) return false;

            driver.FindElement(By.Id("nav-menu-dropdown")).Click();
            Thread.Sleep(500);
            
            bool nameMatch = driver.FindElements(By.XPath($"//a[contains(text(), '{username}')]")).Count > 0;
            
            driver.FindElement(By.Id("nav-menu-dropdown")).Click();
    
            return nameMatch;
        }
    }
}
