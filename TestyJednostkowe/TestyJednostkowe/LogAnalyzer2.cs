using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    public class LogAnalyzer2
    {
        public bool wasLastFileNameIsValid { get; set; }

        public bool IsValidLogFileName(string fileName)
        {
            wasLastFileNameIsValid = false;
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("Podaj nazwę pliku");
            }
            if (!fileName.EndsWith(".slf", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            wasLastFileNameIsValid = true;
            return true;
        }
    }
}
