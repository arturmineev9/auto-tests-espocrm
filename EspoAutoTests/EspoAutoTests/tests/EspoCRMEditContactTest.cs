using EspoAutoTests.Model;
using EspoAutoTests.tests;

namespace EspoAutoTests.Tests
{
    [TestFixture, Order(3)]
    public class EditContactTest : AuthBase
    {
        [Test]
        public void Test3_EditContact()
        {
            // Данные для теста
            ContactData newData = new ContactData("Edited") { LastName = "Tester" };
            string expectedName = "Edited Tester";

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
