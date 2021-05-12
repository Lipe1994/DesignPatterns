using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAdapter
{
    public interface Ilogger
    {
        void Log(String message);
        void LogError(Exception exception);
    }
}
