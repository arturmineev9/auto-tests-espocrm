namespace EspoAutoTests.Model
{
    public class ContactData
    {
        public ContactData() { }

        public ContactData(string firstName)
        {
            FirstName = firstName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}