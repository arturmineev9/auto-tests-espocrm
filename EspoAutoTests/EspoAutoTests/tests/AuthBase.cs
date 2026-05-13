using EspoAutoTests.Model;
using EspoAutoTests.Tests;

namespace EspoAutoTests.tests
{
    public class AuthBase : TestBase
    {
        [SetUp]
        public void SetupLogin()
        {
            AccountData account = new AccountData(Settings.Username, Settings.Password);
            
            app.Navigation.GoToHomePage();
            app.Auth.Login(account);
        }
    }
}