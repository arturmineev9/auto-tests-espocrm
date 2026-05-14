using System.Xml;

namespace SoundRecorderTests
{
    public static class Settings
    {
        private static string file = "Settings.xml";
        private static XmlDocument document;
        
        private static string appId;
        private static string driverUri;

        static Settings()
        {
            string baseDir = AppContext.BaseDirectory;
            string fullPath = Path.Combine(baseDir, file);
            
            document = new XmlDocument();
            document.Load(fullPath);
        }

        public static string AppId
        {
            get 
            {
                if (appId == null)
                    appId = document.DocumentElement.SelectSingleNode("AppId").InnerText;
                return appId;
            }
        }

        public static string DriverUri
        {
            get 
            {
                if (driverUri == null)
                    driverUri = document.DocumentElement.SelectSingleNode("DriverUri").InnerText;
                return driverUri;
            }
        }
    }
}