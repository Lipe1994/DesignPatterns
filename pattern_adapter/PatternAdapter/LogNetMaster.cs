using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAdapter
{
    public class LogNetMaster : IlogNetMaster
    {
        public void LogException(Exception exception)
        {
            Console.WriteLine("Log Customizado " + exception.Message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("Log Customizado " + message);
        }
    }
}
