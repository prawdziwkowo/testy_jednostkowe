﻿using System;
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
            return fileName.EndsWith(".slf", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
