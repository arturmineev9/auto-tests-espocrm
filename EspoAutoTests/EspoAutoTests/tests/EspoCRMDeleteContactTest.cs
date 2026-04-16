

namespace EspoAutoTests.Tests
{
    [TestFixture, Order(4)]
    public class DeleteContactTest : TestBase
    {
        [Test]
        public void Test4_DeleteContact()
        {
            app.Navigation.GoToHomePage();
            app.Auth.Login();
            app.Navigation.GoToContactsPage();

            app.Contact.SelectFirstContact();
            app.Contact.RemoveContact();
        }
    }
}
