using OpenQA.Selenium;

namespace EspoAutoTests
{
    public class HelperBase
    {
        protected AppManager manager;
        protected IWebDriver driver;

        public HelperBase(AppManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver;
        }
    }
}
