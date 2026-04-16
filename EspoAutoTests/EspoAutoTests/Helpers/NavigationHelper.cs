using OpenQA.Selenium;

namespace EspoAutoTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(AppManager manager, string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void GoToHomePage()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(baseURL);
        }

        public void GoToContactsPage()
        {
            driver.FindElement(By.CssSelector(".fa-id-badge")).Click();
            Thread.Sleep(2000);
        }
    }
}
