using EspoAutoTests.Model;
using System.Xml.Serialization;

namespace EspoAutoTests.Tests
{
    [TestFixture, Order(2)]
    public class CreateContactTest : TestBase
    {
        public static IEnumerable<ContactData> ContactDataFromXmlFile()
        {
            return (List<ContactData>)new XmlSerializer(typeof(List<ContactData>))
                .Deserialize(new StreamReader(@"contacts.xml"));
        }

        [Test, TestCaseSource("ContactDataFromXmlFile")]
        public void Test2_CreateContact(ContactData contact)
        {

            app.Navigation.GoToHomePage();
            app.Auth.Login();
            app.Navigation.GoToContactsPage();

            app.Contact.InitContactCreation();
            app.Contact.FillContactForm(contact);
            app.Contact.SubmitContactCreation();

            string expectedName = contact.FirstName + " " + contact.LastName;

            Thread.Sleep(1000);

            string realName = app.Contact.GetContactFullNameFromPage();
            Assert.That(realName, Is.EqualTo(expectedName.Trim()));
        }
    }
}
