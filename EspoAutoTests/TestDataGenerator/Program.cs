using EspoAutoTests.Model;
using System.Xml.Serialization;

namespace TestDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Нужно передать 3 параметра: количество, имя_файла, формат");
                return;
            }

            int count = Convert.ToInt32(args[0]);
            string filename = args[1];
            string format = args[2];

            List<ContactData> contacts = new List<ContactData>();
            for (int i = 0; i < count; i++)
            {
                contacts.Add(new ContactData()
                {
                    FirstName = GenerateRandomString(8),
                    LastName = GenerateRandomString(12)
                });
            }

 
             WriteContactsToXmlFile(contacts, filename);
        }


        static void WriteContactsToXmlFile(List<ContactData> contacts, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ContactData>));
            using (StreamWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, contacts);
            }
        }

        static string GenerateRandomString(int max)
        {
            Random rnd = new Random();
            int length = rnd.Next(3, max);
            char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            string word = "";
            for (int i = 0; i < length; i++)
            {
                word += letters[rnd.Next(letters.Length)];
            }
            return word;
        }
    }
}