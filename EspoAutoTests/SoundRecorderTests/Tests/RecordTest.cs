using SoundRecorderTests.Base;

namespace SoundRecorderTests.Tests
{
    [TestFixture]
    public class RecordTest : TestBase
    {
        [Test]
        public void Test_CreateAudioRecord()
        {
            app.Record.StartRecording();
            
            Thread.Sleep(3000); // Пишем звук
            
            app.Record.StopRecording();
            
            Assert.That(app.Record.IsRecordSaved(), Is.True);
        }
    }
}
