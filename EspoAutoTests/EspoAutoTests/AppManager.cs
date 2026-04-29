using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EspoAutoTests
{
    public class AppManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected NavigationHelper navigation;
        protected LoginHelper auth;
        protected ContactHelper contact;

        private static ThreadLocal<AppManager> app = new ThreadLocal<AppManager>();

        private AppManager()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--incognito");
            options.AddArgument("--lang=en-US");

            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            baseURL = "https://demo.eu.espocrm.com/";

            navigation = new NavigationHelper(this, baseURL);
            auth = new LoginHelper(this);
            contact = new ContactHelper(this);
        }

        ~AppManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
            }
        }

        public static AppManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                AppManager newInstance = new AppManager();
                newInstance.Navigation.GoToHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }

        public IWebDriver Driver { get { return driver; } }
        public NavigationHelper Navigation { get { return navigation; } }
        public LoginHelper Auth { get { return auth; } }
        public ContactHelper Contact { get { return contact; } }
    }
}
