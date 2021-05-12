using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAdapter
{
    public class LogAdapter : Ilogger
    {
        private readonly IlogNetMaster logger;

        public LogAdapter(IlogNetMaster _logger)
        {
            logger = _logger;
        }

        public void Log(string message)
        {
            logger.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            logger.LogException(exception);
        }
    }
}
