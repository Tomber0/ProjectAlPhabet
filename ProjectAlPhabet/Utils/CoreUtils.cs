using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjectAlPhabet.Model;
using System.IO;
using System.Reflection;

namespace ProjectAlPhabet.Utils
{
    internal static class CoreUtils
    {
        public static void FetchImage(string imageUrl) 
        {
            // use request to page
        }

        public static int GetRandomImagePage(int maxPages) 
        {
            return new Random().Next(maxPages);
        }

        public static bool IsPictureInLimits()
        {

            return true;
        }

        public static bool IsInitialFilePresented()
        {
            return File.Exists(Path.Combine(FileConfig.Default));
        }

        public static void CreateIniFile() 
        {
            using (StreamWriter sw = new(Path.Combine(FileConfig.Default)))
            {
                JsonSerializer serializer = new JsonSerializer();
                ConfigsCore obj = new ConfigsCore();
                serializer.Serialize(sw, obj);
            }
        }

        public static void ReadIniFile()
        {
            JToken obj = null;
            using (StreamReader sr = new(Path.Combine(FileConfig.Default)))
            {
                JsonSerializer serializer = new JsonSerializer();
                obj = (JToken)serializer.Deserialize(sr, typeof(JToken));
            }
            MapJTokenToStaticClass(obj);

        }
        private static void MapJTokenToStaticClass(JToken source)
        {
            var destinationProperties = typeof(ConfigsCore)
                .GetProperties(BindingFlags.Public | BindingFlags.Static);
            foreach (JProperty prop in source)
            {
                var destinationProp = destinationProperties
                    .SingleOrDefault(p => p.Name.Equals(prop.Name, StringComparison.OrdinalIgnoreCase));
                var value = ((JValue)prop.Value).Value;
                destinationProp.SetValue(null, Convert.ChangeType(value, destinationProp.PropertyType));
            }
        }

    }
}
