using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    public class LogAnalyzerStubs
    {
        private IExtentionManager manager;

        public LogAnalyzerStubs(IExtentionManager mgr)
        {
            manager = mgr;
        }
        public bool isValidLogFileName(string fileName)
        {
            return manager.isValid(fileName);
        }
    }

    public interface IExtentionManager
    {
        bool isValid(string fileName);
    }

    public class FileExtentionManager : IExtentionManager
    {
        public bool isValid(string fileName)
        {
            return true;
        }
    }

    //namiasta
    public class AlwaysValidFakeExtentionManager : IExtentionManager
    {
        public bool isValid(string fileName)
        {
            return true;
        }
    }
}
