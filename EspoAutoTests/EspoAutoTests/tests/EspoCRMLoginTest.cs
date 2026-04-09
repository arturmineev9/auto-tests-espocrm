using OpenQA.Selenium;

namespace EspoAutoTests
{
    [TestFixture, Order(1)]
    public class LoginTest : TestBase
    {

        [Test]
        public void LoginToEspoCRM()
        {
            GoToHomePage();
            Login();
        }
    }
}
