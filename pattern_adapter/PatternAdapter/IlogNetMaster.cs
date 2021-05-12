using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAdapter
{
    public interface IlogNetMaster
    {
        void LogInfo(String message);

        void LogException(Exception exception);
    }
}
