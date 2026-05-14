using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace SoundRecorderTests
{
    public class AppManager
    {
        private WindowsDriver<WindowsElement> driver;
        public RecordHelper Record { get; private set; }

        public AppManager()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", "Microsoft.WindowsSoundRecorder_8wekyb3d8bbwe!App");
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Record = new RecordHelper(driver);
        }

        public void Stop()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}