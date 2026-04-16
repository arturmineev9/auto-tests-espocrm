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
            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(2000);
        }
    }
}
