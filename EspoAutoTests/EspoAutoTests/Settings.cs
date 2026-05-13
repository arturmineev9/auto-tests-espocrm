using System.Xml;

namespace EspoAutoTests
{
    public static class Settings
    {
        private static string file = "Settings.xml";
        private static XmlDocument document;
        
        private static string baseUrl;
        private static string username;
        private static string password;

        static Settings()
        {
            if (!File.Exists(file)) 
            { 
                throw new Exception("Файл настроек не найден: " + Path.GetFullPath(file)); 
            }
            document = new XmlDocument();
            document.Load(file);
        }

        public static string BaseUrl
        {
            get {
                if (baseUrl == null)
                    baseUrl = document.DocumentElement.SelectSingleNode("BaseUrl").InnerText;
                return baseUrl;
            }
        }

        public static string Username
        {
            get {
                if (username == null)
                    username = document.DocumentElement.SelectSingleNode("Username").InnerText;
                return username;
            }
        }

        public static string Password
        {
            get {
                if (password == null)
                    password = document.DocumentElement.SelectSingleNode("Password").InnerText;
                return password;
            }
        }
    }
}