using EspoAutoTests.Model;

namespace EspoAutoTests.Tests
{
    [TestFixture, Order(3)]
    public class EditContactTest : TestBase
    {
        [Test]
        public void Test3_EditContact()
        {
            ContactData newData = new ContactData("Artur") { LastName = "Min" };
            string expectedName = "Artur Min";

            app.Navigation.GoToHomePage();
            app.Auth.Login();
            app.Navigation.GoToContactsPage();

            app.Contact.SelectFirstContact();
            app.Contact.InitContactModification();
            app.Contact.ModifyContactForm(newData);
            app.Contact.SubmitContactModification();

            app.Navigation.OpenContactProfileByText(expectedName);

            string realName = app.Contact.GetContactFullNameFromPage();
            Assert.That(realName, Is.EqualTo(expectedName));
        }
    }
}
