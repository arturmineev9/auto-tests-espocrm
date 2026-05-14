using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using SoundRecorderTests.Helpers;

namespace SoundRecorderTests
{
    public class AppManager
    {
        private WindowsDriver<WindowsElement> driver;
        public RecordHelper Record { get; private set; }

        private static ThreadLocal<AppManager> app = new();

        private AppManager()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", Settings.AppId);
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            driver = new WindowsDriver<WindowsElement>(new Uri(Settings.DriverUri), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Record = new RecordHelper(this);
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
                app.Value = new AppManager();
            }

            return app.Value;
        }

        public WindowsDriver<WindowsElement> Driver
        {
            get { return driver; }
        }
    }
}