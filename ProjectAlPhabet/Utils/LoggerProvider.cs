using NLog;

namespace ProjectAlPhabet.Utils
{
    internal static class LoggerProvider
    {
        public static Logger? _logger;
        public static Logger Logger 
        {
            get
            {
                if (_logger == null) 
                {
                    _logger = LogManager.GetLogger("file");
                }
                return _logger;
            }
            set 
            {
                _logger = value;
            }
        }
    }
}
