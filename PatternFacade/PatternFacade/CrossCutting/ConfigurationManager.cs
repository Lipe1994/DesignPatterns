using PatternFacade.CrossCutting.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFacade.CrossCutting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public String GetValue(String node)
        {
            return new String(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10).Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
