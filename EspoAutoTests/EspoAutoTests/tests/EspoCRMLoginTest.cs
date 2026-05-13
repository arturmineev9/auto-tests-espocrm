using EspoAutoTests.Model;

namespace EspoAutoTests.Tests
{
    [TestFixture, Order(1)]
    public class LoginTest : TestBase
    {
        [Test]
        public void Test1_JustLogin()
        {
            AccountData admin = new AccountData(Settings.Username, Settings.Password);
            app.Auth.Login(admin);
            Thread.Sleep(2000); 
            Assert.That(app.Auth.IsLoggedIn(), Is.True);
        }
    }
}
