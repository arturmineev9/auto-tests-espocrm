using SoundRecorderTests.Base;

namespace SoundRecorderTests.Helpers
{
    public class RecordHelper : HelperBase
    {
        public RecordHelper(AppManager manager) : base(manager) { }

        public void StartRecording()
        {
            driver.FindElementByName("Начать запись").Click();
        }

        public void StopRecording()
        {
            driver.FindElementByName("Остановить запись").Click();
        }
        
        public bool IsRecordSaved()
        {
            return driver.FindElementsByName("Воспроизвести").Count > 0;
        }
    }
}