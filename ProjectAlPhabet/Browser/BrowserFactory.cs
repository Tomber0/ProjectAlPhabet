using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectAlPhabet.Utils;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace ProjectAlPhabet.Browser
{
    class BrowserFactory
    {
        private static IWebDriver _driver;
        private static ICapabilities? _capabilities;

        public static ICapabilities? Capabilities
        {
            get
            {
                LoggerProvider.Logger.Info($"Getting browser capabilities");
                _capabilities = ((WebDriver)_driver).Capabilities;
                return _capabilities;
            }
            private set
            {
                _capabilities = value;
            }
        }


        public static IWebDriver? Driver 
        {
            get 
            {
                switch (BrowserConfigurations.Browser) 
                {
                    case "chrome":
                        LoggerProvider.Logger.Info($"Creating new chrome driver");
                        ChromeOptions options = new ChromeOptions();
                        foreach (string arg in BrowserConfigurations.Arguments)
                        {
                            LoggerProvider.Logger.Info($"Added an argument: `{arg}`");
                            options.AddArgument(arg);
                        }
                        foreach (KeyValuePair<string, string> arg in BrowserConfigurations.Preferences)
                        {
                            LoggerProvider.Logger.Info($"Added a preference: `{arg.Key}` - `{arg.Value}`");
                            options.AddUserProfilePreference(arg.Key, arg.Value);
                        }
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        _driver = new ChromeDriver(options);
                        return _driver;
                    default:
                        break;
                }
                return _driver;
            }
        }
    }
}


/*
 * 
 * 
 *     internal class BrowserFactory
    {
        private static IWebDriver? _driver;
        private static ICapabilities? _capabilities;
        public static IWebDriver? Driver
        {
            get
            {
                switch (Configuration.GetValueFromCollection("browser"))
                {
                    case "chrome":
                        {
                            LoggerProvider.Logger.Info($"Creating new chrome driver");
                            ChromeOptions options = new ChromeOptions();
                            options.AddArgument("--lang=" + Configuration.GetValueFromCollection("lang"));
                            options.AddArgument(Configuration.GetValueFromCollection("incognito"));
                            options.AddUserProfilePreference("download.default_directory", AppContext.BaseDirectory + Configuration.GetValueFromCollection("default-path"));
                            options.AddUserProfilePreference("disable-popup-blocking", Configuration.GetValueFromCollection("disable-popup-blocking"));
                            new DriverManager().SetUpDriver(new ChromeConfig());
                            _driver = new ChromeDriver(options);
                            return _driver;
                        }
                    case "firefox":
                        {
                            LoggerProvider.Logger.Info($"Creating new firefox driver");
                            FirefoxOptions options = new FirefoxOptions();
                            options.AddArgument("--lang=" + Configuration.GetValueFromCollection("lang"));
                            options.AddArgument(Configuration.GetValueFromCollection("incognito"));
                            new DriverManager().SetUpDriver(new FirefoxConfig());
                            _driver = new FirefoxDriver(options);
                            return _driver;
                        }
                    default:
                        LoggerProvider.Logger.Error($"No webdriver was provided");
                        throw new Exception("No web-browser given in config.json file!");
                }
            }
            private set { _driver = value; }
        }

        public static ICapabilities? Capabilities
        {
            get
            {
                LoggerProvider.Logger.Info($"Getting browser capabilities");
                _capabilities = ((WebDriver)_driver).Capabilities;
                return _capabilities;
            }
            private set
            {
                _capabilities = value;
            }
        }


    }

 */