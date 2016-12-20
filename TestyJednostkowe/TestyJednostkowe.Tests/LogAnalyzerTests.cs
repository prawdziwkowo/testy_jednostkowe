using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestyJednostkowe;

namespace TestyJednostkowe.Tests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [TestCase("hsdjfhf.SLF", true)]
        [TestCase("hsdjfhf.slf", true)]
        [TestCase("hsdjfhf.foo", false)]
        public void IsValidFileName_ValidExtension_CheckThem(String fileName, bool expected)
        {
            LogAnalyzer an = new LogAnalyzer();
            bool results = an.IsValidLogFileName(fileName);
            Assert.AreEqual(expected, results);
        }
        
    }
}
