namespace EspoAutoTests.Tests
{
    [TestFixture, Order(1)]
    public class LoginTest : TestBase
    {
        [Test]
        public void Test1_JustLogin()
        {
            app.Navigation.GoToHomePage();
            app.Auth.Login();
        }
    }
}
