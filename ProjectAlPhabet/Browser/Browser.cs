using OpenQA.Selenium;
using ProjectAlPhabet.Utils;

namespace ProjectAlPhabet.Browser
{
    internal class Browser
    {
        private static IWebDriver? _driver;

        public static IWebDriver? Driver
        {
            get
            {
                if (_driver == null)
                {
                    LoggerProvider.Logger.Info($"Getting driver");
                    _driver = BrowserFactory.Driver;
                }
                return _driver;
            }
        }
    }
}
