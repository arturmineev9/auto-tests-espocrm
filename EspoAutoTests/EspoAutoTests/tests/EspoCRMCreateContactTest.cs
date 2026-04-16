using EspoAutoTests.Model;
using EspoAutoTests.Tests;

namespace EspoAutoTests.Tests
{
    [TestFixture, Order(2)]
    public class CreateContactTest : TestBase
    {
        [Test]
        public void Test2_CreateContact()
        {
            ContactData contact = new ContactData("Artur") { LastName = "M" };

            app.Navigation.GoToHomePage();
            app.Auth.Login();
            app.Navigation.GoToContactsPage();

            app.Contact.InitContactCreation();
            app.Contact.FillContactForm(contact);
            app.Contact.SubmitContactCreation();
        }
    }
}
