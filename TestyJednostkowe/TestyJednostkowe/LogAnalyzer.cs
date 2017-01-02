using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("Podaj nazwę pliku");
            }
            return fileName.EndsWith(".slf", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
