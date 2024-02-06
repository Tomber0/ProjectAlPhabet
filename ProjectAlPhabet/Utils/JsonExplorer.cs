using Newtonsoft.Json;
using System.IO;

namespace ProjectAlPhabet.Utils
{
    class JsonExplorer
    {
        public static List<string> ReadCollectionFromJsonFile(string fileName, string attrName) 
        {
            List<string> result = new List<string>();
            using (StreamReader sr = new(fileName))
            {
                result = JsonConvert.DeserializeObject<List<string>>(sr.ReadToEnd());
            }
            return result;
        }

        public static Dictionary<string,string> ReadObjectFromJsonFile(string fileName, string attrName) 
        {
            Dictionary<string, string> result = new();
            using (StreamReader sr = new(fileName))
            {
                result = JsonConvert.DeserializeObject<Dictionary<string, string>>(sr.ReadToEnd());
            }
            return result;
        }

        public static string ReadStringFromJsonFile(string fileName, string attrName) 
        {
            string result = string.Empty;
            using (StreamReader sr = new(fileName))
            {
                result = JsonConvert.DeserializeObject<string>(sr.ReadToEnd());
            }
            return result;
        }
    }
}
