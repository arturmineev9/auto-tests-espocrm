using OpenQA.Selenium.Appium.Windows;

namespace SoundRecorderTests
{
    public class RecordHelper
    {
        private WindowsDriver<WindowsElement> driver;

        public RecordHelper(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public void StartRecording()
        {
            driver.FindElementByName("Начать запись").Click();
        }

        public void StopRecording()
        {
            driver.FindElementByName("Остановить запись").Click();
        }
    }
}