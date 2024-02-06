using Newtonsoft.Json;
using ProjectAlPhabet.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlPhabet.Browser
{
    internal class BrowserConfigurations
    {
        private static string _browser;
        private static List<string> _userArgs = null;
        private static Dictionary<string,string> _params;

        public static Dictionary<string, string> Preferences 
        {
            get 
            {
                if (_params is null) 
                {
                    _params = JsonExplorer.ReadObjectFromJsonFile(ConfigurationProvider.BrowserConfigFilePath, "params");
                }
                return _params; 
            }
        }

        public static List<string> Arguments
        {
            get 
            {
                if (_userArgs is null) 
                {
                    _userArgs = JsonExplorer.ReadCollectionFromJsonFile(ConfigurationProvider.BrowserConfigFilePath, "args");
                }
                return _userArgs; 
            }
        }

        public static string Browser 
        {
            get 
            {
                if (string.IsNullOrEmpty(_browser))
                {
                    _browser = JsonExplorer.ReadStringFromJsonFile(ConfigurationProvider.BrowserConfigFilePath, "browser");
                }
                return _browser; 
            }
        }

    }
}
