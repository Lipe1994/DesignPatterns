using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAdapter
{
    public class Logger : Ilogger
    {
        public void Log(String message)
        {
            Console.WriteLine("Log padrão - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Log padrão" + exception.Message);
        }
    }
}
