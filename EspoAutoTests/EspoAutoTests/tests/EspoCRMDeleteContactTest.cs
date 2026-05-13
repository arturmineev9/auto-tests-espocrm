using EspoAutoTests.tests;

namespace EspoAutoTests.Tests
{
    [TestFixture, Order(4)]
    public class DeleteContactTest : AuthBase 
    {
        [Test]
        public void Test4_DeleteContact()
        {
            app.Navigation.GoToContactsPage();
            app.Contact.SelectFirstContact();
            app.Contact.RemoveContact();
        }
    }
}