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
        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer an = new LogAnalyzer();
            bool results = an.IsValidLogFileName("hsdjfhf.foo");
            Assert.False(results);
        }
        
        [Test]
        public void IsValidFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            LogAnalyzer an = new LogAnalyzer();
            bool results = an.IsValidLogFileName("hsdjfhf.SLF");
            Assert.True(results);
        }

        [Test]
        public void IsValidFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            LogAnalyzer an = new LogAnalyzer();
            bool results = an.IsValidLogFileName("hsdjfhf.slf");
            Assert.True(results);
        }
    }
}
