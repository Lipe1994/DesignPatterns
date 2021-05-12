using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFacade.CrossCutting.contracts
{
    public interface IConfigurationManager
    {
        public String GetValue(String node);
    }
}
