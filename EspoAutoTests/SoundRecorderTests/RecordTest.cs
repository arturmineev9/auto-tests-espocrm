namespace SoundRecorderTests
{
    [TestFixture]
    public class RecordTest
    {
        private AppManager app;

        [SetUp]
        public void Setup()
        {
            app = new AppManager();
        }

        [TearDown]
        public void Teardown()
        {
            app.Stop();
        }

        [Test]
        public void Test_CreateAudioRecord()
        {
            app.Record.StartRecording();

            Thread.Sleep(3000);

            app.Record.StopRecording();
        }
    }
}