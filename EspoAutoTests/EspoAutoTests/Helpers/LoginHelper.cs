using OpenQA.Selenium;

namespace EspoAutoTests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(AppManager manager)
            : base(manager)
        {
        }

        public void Login()
        {
            if (driver.FindElements(By.Id("btn-login")).Count == 0)
            {
                return;
            }

            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(2000);
        }
    }
}
